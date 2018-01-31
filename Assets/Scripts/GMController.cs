using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GMController : MonoBehaviour {
    [SerializeField]
    private Text txtScores;
    [SerializeField]
    private Text txtLives;

    private int lives;
    private int scores;
    private bool isGameOver = false;

    private static GMController instance;

    public static GMController Instance
    {
        get
        {
            return instance;
        }
    }

    public bool IsGameOver
    {
        get
        {
            return isGameOver;
        }
    }

    // Use this for initialization
    void Start () {
        instance = this;
        isGameOver = false;
        lives = GlobalGameController.Instance.Lives;
        scores = GlobalGameController.Instance.Score;
        UpdateStatsUI();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnDeadZoneCollision()
    {
        LooseLife();
        BallController.Instance.ReturnToStartPosition();
    }

    private void LooseLife()
    {
        lives--;
        UpdateStatsUI();
        CheckForGameOver();
    }

    private void CheckForGameOver()
    {
        if (lives < 0)
        {
            lives = 0;
            UpdateStatsUI();
            GameOver();
        }
    }

    private void GameOver()
    {
        isGameOver = true;
    }

    private void UpdateStatsUI()
    {
        txtScores.text = scores.ToString();
        txtLives.text = lives.ToString();
    }

    public void AddScore(int scoreToAdd)
    {
        scores += scoreToAdd;
        UpdateStatsUI();
    }
}
