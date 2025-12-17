using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class dropZone : MonoBehaviour, IDropHandler
{
   public void OnDrop(PointerEventData eventData)
   {
        bookManager.Instance.isReading = false;
        SceneManager.LoadScene("Level");
   }
}
