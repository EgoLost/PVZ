using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clicker : MonoBehaviour
{

    public static  Clicker Instance;

    public float Money
    {
        get => PlayerPrefs.GetFloat("Money", 0);
        set => PlayerPrefs.SetFloat("Money", value);
    }

    [SerializeField]
    private TextMeshProUGUI money;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(PassiveGamageDealer());
        UpdateUI();
    
    }

    private IEnumerator PassiveGamageDealer()
    {
        while(true)
        {
            yield return new WaitForSeconds(1);
            DamageTarget(GetPassiveDamage());
        }
    }

    public void Click()
    {
        DamageTarget(GetClickDamage());
    }

    private void DamageTarget(float damage)
    {
        Money += damage;
        UpdateUI();
    }
    
    private float GetClickDamage()
    {
        float damage = 1;

        return damage;
    }

    private float GetPassiveDamage()
    {
        float damage = 2;

        return damage;
    }

    public void UpdateUI()
    {
        money.text = "Score: " + (int)Money;
    }
}
