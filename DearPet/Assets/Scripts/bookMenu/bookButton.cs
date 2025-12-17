using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bookButton : MonoBehaviour
{
    [SerializeField] private string bookID;
    [SerializeField] private string sceneNameB;
    [SerializeField] private int price;

    public void OnClick()
    {
        if (GameUnlockManager.isUnlockB(bookID))
        {
            SceneManager.LoadScene(bookID);
        }
        else
        {
            unlockBooks();
        }

    }

    public void unlockBooks()
    {
        Debug.Log("Para: " + MoneyManager.instance.money);

        if (MoneyManager.instance.SpendMoney(price))
        {
            GameUnlockManager.unlockBook(bookID);
            SceneManager.LoadScene(sceneNameB);
        }
        else
        {
            Debug.Log("yetersiz para");
        }
    }
}
