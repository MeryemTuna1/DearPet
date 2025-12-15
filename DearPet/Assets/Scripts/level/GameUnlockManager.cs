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
}
