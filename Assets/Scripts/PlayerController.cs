using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    [SerializeField]
    private float speed;

    private Rigidbody2D myRigidbody;

	// Use this for initialization
	void Start () {
        myRigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        MoveHandler();
    }

    private void MoveHandler()
    {
        float yVelocity = Input.GetAxisRaw("Mouse X");

        myRigidbody.velocity = new Vector2(yVelocity * speed * Time.deltaTime, 0);
    }
}
