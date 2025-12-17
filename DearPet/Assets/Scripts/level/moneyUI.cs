using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moneyUI : MonoBehaviour
{
    [SerializeField] private Text money;

    void Update()
    {
        if (MoneyManager.instance != null)
        {
            money.text=MoneyManager.instance.money.ToString();
        }
    }
}
