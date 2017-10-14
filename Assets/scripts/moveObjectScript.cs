using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Moves the object in a direction
/// </summary>

public class moveObjectScript : MonoBehaviour {
    //speed
    public Vector2 speed = new Vector2(10, 10);

    private Rigidbody2D rb;

    //direction
    public Vector2 direction = new Vector2(-1, 0);
    private Vector2 movement;


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        //calculation of the movement
        movement = new Vector2(
          speed.x * direction.x,
          speed.y * direction.y);
    }

    void FixedUpdate() {
        //move
        rb.velocity = movement;
    }

}