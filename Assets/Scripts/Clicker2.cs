using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clicker2 : MonoBehaviour
{

    public static  Clicker2 Instance;

    public float Money2
    {
        get => PlayerPrefs.GetFloat("Money2", 0);
        set => PlayerPrefs.SetFloat("Money2", value);
    }

    [SerializeField]
    private TextMeshProUGUI money2;

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

    private void DamageTarget(float damage2)
    {
        Money2 += damage2;
        UpdateUI();
    }
    
    private float GetClickDamage()
    {
        float damage2 = 1;

        return damage2;
    }

    private float GetPassiveDamage()
    {
        float damage2 = 2;

        return damage2;
    }

    public void UpdateUI()
    {
        money2.text = "Score: " + (int)Money2;
    }
}
