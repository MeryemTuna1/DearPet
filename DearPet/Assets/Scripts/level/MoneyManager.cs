using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
   
    public static MoneyManager instance;
    public int money;
  

    private void Awake()
    {
        

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            money = PlayerPrefs.GetInt("Money", 0);
        }
        else 
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        ResetMoney();
    }

    
    public void AddMoney(int deger)
    {
        money += deger;
        PlayerPrefs.SetInt("Money",money);
    }

    public bool SpendMoney(int deger)
    {
        if (money>=deger)
        {
            money -= deger;
            PlayerPrefs.SetInt("Money",money);
            return true;
        }

        return false;
    }

    public void ResetMoney()
    {
        money = 0;
        PlayerPrefs.SetInt("Money",money);
    }
}
