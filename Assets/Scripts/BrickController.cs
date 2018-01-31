using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickController : MonoBehaviour {
    [SerializeField]
    private int health = 1;
    [SerializeField]
    private int score = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            health -= BallController.Instance.Strenght;
            CheckForDestroy();
        }
    }

    private void CheckForDestroy()
    {
        if (health <= 0)
        {
            GMController.Instance.AddScore(score);
            Destroy(gameObject);
        }
    }
}
