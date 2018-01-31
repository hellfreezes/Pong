using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalGameController : MonoBehaviour {
    [SerializeField]
    private int livesAtStart = 3;

    private int lives;

    private int score;

    private static GlobalGameController instance;

    public int Lives
    {
        get
        {
            return lives;
        }

        set
        {
            lives = value;
        }
    }

    public int Score
    {
        get
        {
            return score;
        }

        set
        {
            score = value;
        }
    }

    public static GlobalGameController Instance
    {
        get
        {
            return instance;
        }
    }

    // Use this for initialization
    void Start () {
        if (instance == null)
        {
            instance = this;
        } else
        {
            Destroy(gameObject);
        }
        ResetScoresAndLives();
        DontDestroyOnLoad(gameObject);
	}
	
	private void ResetScoresAndLives()
    {
        lives = livesAtStart;
        score = 0;
    }
}
