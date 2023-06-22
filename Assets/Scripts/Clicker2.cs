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

    public void VodkaClick()
    {
        DamageTarget(Vodka());
    }

    private float Vodka()
    {
        float damage = 1;
        return damage;
    }

    private void DamageTarget(float damage)
    {
        Money2 += damage;
        UpdateUI();
    }

    public void MatreshkaClick()
    {
        DamageTarget(Matreshka());
    }
    
    private float Matreshka()
    {
        float damage = 5;

        return damage;
    }

    public void BearClick()
    {
        DamageTarget(Bear());
    }
    
    private float Bear()
    {
        float damage = 10;

        return damage;
    }

    public void ZClick()
    {
        DamageTarget(Z());
    }
    
    private float Z()
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
        money2.text = "Score: " + (int)Money2;
    }
}
