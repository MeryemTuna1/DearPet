using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private int score;
    [SerializeField] private Text scoreT;
    [SerializeField] private reward r;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    private void Update()
    {
        if (score>=2)
        {
            r.FinishGame();
        }
    }

    private void Start()
    {
        Application.targetFrameRate = 60;
        UpdateUI();
    }

    public void AddScore(int deger)
    {
        score += deger;
        UpdateUI();
    }

    void UpdateUI()
    {
        if(scoreT!=null)
        {
            scoreT.text = score.ToString();
        }
    }

    public void PlayerHitObstacle()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
