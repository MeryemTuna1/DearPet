using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class canManager : MonoBehaviour
{
    public static canManager instance;

    [SerializeField] private int score=0;
    [SerializeField] private int life = 3;
    [SerializeField] private Text scoreT;
    [SerializeField] private Image[] canImage;
    [SerializeField] private reward r;
   
    private void Awake()
    {
        instance = this;
    }
    private void Update()
    {
        scoreT.text = score.ToString();
        if (score>=2 )
        {
            r.FinishGame();
        }
    }
    public void AddScore(int value)
    {
        score += value;
       
    }
    public void LoseLife()
    {
        score -= 1;
        life--;
        canImage[life].enabled = false;

        if (life <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //sahneyi yeniden yükle
        }

       
    }
}
