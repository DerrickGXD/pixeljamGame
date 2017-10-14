using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Player Controls
/// </summary>
public class playerMoves : MonoBehaviour {
    //0 - controls
    public string xAxis = "Horizontal";
    public string yAxis = "Vertical";


    //1 - speed
    public Vector2 speed = new Vector2(50, 50);

    //2 - rigid body
    private Rigidbody2D rb;

    //3 - movement
    private Vector2 movement;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
	}


	
	// Update is called once per frame
	void Update () {
        //Get inputs
        float inputX = Input.GetAxis(xAxis);
        float inputY = Input.GetAxis(yAxis);

        //calculate the movement
        movement = new Vector2(
            speed.x * inputX,
            speed.y * inputY);

        /*
        //shoot
        bool shoot = Input.GetButtonDown(fire);
        if (shoot) {
            weaponScript weapon = GetComponentInChildren<weaponScript>();
            if (weapon != null) {
                // false : player isn't in team 1
                weapon.Attack(false);
            }
        }
        */
    }

    void FixedUpdate() {
        rb.velocity = movement;
    }
}
