using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUnlockManager : MonoBehaviour
{
   public static bool isUnlock(string gameID)
   {
        return PlayerPrefs.GetInt(gameID,0) == 1;
   }
    public static void unlockGame(string gameID)
    {
       PlayerPrefs.SetInt(gameID, 1);     
    }

    public static bool isUnlockB(string bookID)
    {
        return PlayerPrefs.GetInt(bookID, 0) == 1;
    }
    public static void unlockBook(string bookID)
    {
        PlayerPrefs.SetInt(bookID, 1);
    }
}
