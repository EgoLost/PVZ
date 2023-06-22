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

    public void SaloClick()
    {
        DamageTarget(Salo());
    }

    private float Salo()
    {
        float damage = 1;
        return damage;
    }

    private void DamageTarget(float damage)
    {
        Money += damage;
        UpdateUI();
    }

    public void BorshClick()
    {
        DamageTarget(Borsh());
    }
    
    private float Borsh()
    {
        float damage = 5;

        return damage;
    }

    public void PampushkaClick()
    {
        DamageTarget(Pampushka());
    }
    
    private float Pampushka()
    {
        float damage = 10;

        return damage;
    }

    public void KorovaiClick()
    {
        DamageTarget(Korovai());
    }
    
    private float Korovai()
    {
        float damage = 30;

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
