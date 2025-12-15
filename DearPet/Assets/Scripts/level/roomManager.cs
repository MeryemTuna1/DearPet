using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class roomManager : MonoBehaviour
{
    //mutfak  yatak odasý  bahçe  kütüphane mutfak

    [Header("Panels")]
    [SerializeField] private GameObject kitchenPanel, bedroomPanel, gardenPanel, libraryPanel;

    [Header("Backgrounds")]
    [SerializeField] private SpriteRenderer backgroundRenderer;
    [SerializeField] private Sprite[] backgrounds;
    private int currentIndex = 0;

    private void Start()
    {
        panelClosed();
        kitchenPanel.SetActive(true);
       

        if (backgrounds.Length>0)
        {
            backgroundRenderer.sprite=backgrounds[0];
        }
    }

    public void ileriKB()
    {
        panelClosed();
        bedroomPanel.SetActive(true);
        backgroundRenderer.sprite = backgrounds[1];
    }
    public void geriKB()
    {
        panelClosed();
        libraryPanel.SetActive(true);
        backgroundRenderer.sprite = backgrounds[3];
    }
    public void ileriBB()
    {
        panelClosed();
        gardenPanel.SetActive(true);
        backgroundRenderer.sprite = backgrounds[2];
    }
    public void geriBB()
    {
        panelClosed();
        kitchenPanel.SetActive(true);
        backgroundRenderer.sprite = backgrounds[0];
    }
    public void ileriGB()
    {
        panelClosed();
        libraryPanel.SetActive(true);
        backgroundRenderer.sprite = backgrounds[3];
    }
    public void geriGB()
    {
        panelClosed();
        bedroomPanel.SetActive(true);
        backgroundRenderer.sprite = backgrounds[2];
    }
    public void ileriLB()
    {
        panelClosed();
        kitchenPanel.SetActive(true);
        backgroundRenderer.sprite = backgrounds[0];
    }
    public void geriLB()
    {
        panelClosed();
        gardenPanel.SetActive(true);
        backgroundRenderer.sprite = backgrounds[3];
    }

    public void panelClosed()
    {
        kitchenPanel.SetActive(false);
        bedroomPanel.SetActive(false);
        gardenPanel.SetActive(false);
        libraryPanel.SetActive(false);      
    }

    public void miniGamesOpen()
    {
        SceneManager.LoadScene("miniGames");
    }
}
