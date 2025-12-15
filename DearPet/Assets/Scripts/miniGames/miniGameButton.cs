using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class miniGameButton : MonoBehaviour
{

    [SerializeField] private string gameID;
    [SerializeField] private string sceneName;
    [SerializeField] private int unlockPrice;
    public void OnClick()
    {
        if (GameUnlockManager.isUnlock(gameID))
        {
            SceneManager.LoadScene(gameID);
        }
        else
        {
            tryUnlock();
        }

    }
    public void tryUnlock()
    {
        if (MoneyManager.instance.SpendMoney(unlockPrice))
        {
            GameUnlockManager.unlockGame(gameID);
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.Log("yetersiz para");
        }

    }
}
