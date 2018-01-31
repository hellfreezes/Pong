using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
    [SerializeField]
    private float initiateForce = 800f;
    [SerializeField]
    private Transform paddle;

    private bool launched = false;
    private int strenght = 1;
    private Rigidbody2D myRigidbody;

    private static BallController instance;

    public static BallController Instance
    {
        get
        {
            return instance;
        }
    }

    public int Strenght
    {
        get
        {
            return strenght;
        }
    }

    void Start () {
        instance = this;
        myRigidbody = GetComponent<Rigidbody2D>();
        ReturnToStartPosition();

    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0) && launched == false && GMController.Instance.IsGameOver == false)
        {
            Launch();
        }
	}

    private void Launch()
    {
        transform.parent = null;
        myRigidbody.isKinematic = false;
        myRigidbody.AddForce(new Vector2(initiateForce, initiateForce));
        launched = true;
    }

    public void ReturnToStartPosition()
    {
        myRigidbody.velocity = Vector2.zero;
        myRigidbody.isKinematic = true;
        transform.parent = paddle;
        transform.localPosition = new Vector3(0, 0.75f, 0);
        launched = false;
    }
}
