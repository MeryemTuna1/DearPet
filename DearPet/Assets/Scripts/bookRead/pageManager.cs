using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pageManager : MonoBehaviour
{
    [SerializeField] private GameObject[] pages;
    [SerializeField] private string oyunID;
    int currentPage = 0;

    private void Start()
    {
        showPage(0);
        bookManager.Instance.isReading = true;
    }

    void showPage(int index)
    {
        for (int i = 0; i < pages.Length; i++)
        {
            pages[i].SetActive(i==index);
        }
    }

    public void Next()
    {
        if (currentPage < pages.Length-1)
        {
            currentPage++;
            showPage(currentPage);
        }
    }

    public void Prev()
    {
        if(currentPage > 0)
        {
            currentPage--;
            showPage(currentPage);  
        }
    }

    public void FinishBook()
    {
        bookManager.Instance.isReading=false;
        SceneManager.LoadScene(oyunID);
    }
}
