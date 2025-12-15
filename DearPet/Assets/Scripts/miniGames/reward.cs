using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reward : MonoBehaviour
{
    [SerializeField] private int rewardMoney;
    public void FinishGame()
    {
        MoneyManager.instance.AddMoney(rewardMoney);
        SceneManager.LoadScene("Level");
    }
}
