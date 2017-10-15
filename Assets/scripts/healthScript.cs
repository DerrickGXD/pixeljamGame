using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// health points & destroy

public class healthScript : MonoBehaviour {
    //health points
    public int hp = 1;

    public float begin_x = 5;
    public float begin_y = 5;
    //team
    public int team = 1;

    private gameManager _gm_ = null;

    // Use this for initialization
    void Start () {
        _gm_ = GameObject.FindObjectOfType<gameManager>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void takeHealthOff()
    {
        hp -= 1;

        if (hp <= 0)
        {
            // destroy it self if no more health points !
            gameObject.transform.position = new Vector2(begin_x, begin_y);
            _gm_.addScore(team, -1);
            gameObject.GetComponent<playerInfo>().death += 1;

        }
    }

    void OnCollisionEnter2D(Collision2D collider) {

        /*
        if (gameObject.name == "player1attack" && collider.gameObject.name == "player2attack")
        {
            takeHealthOff();

        }
        if (gameObject.name == "player2attack" && collider.gameObject.name == "player1attack")
        {
            takeHealthOff();
        }
        */
        if (gameObject.name == "player1coins" && collider.gameObject.name == "player2attack")
        {
            takeHealthOff();
            collider.gameObject.GetComponent<playerInfo>().kills += 1;

        }
        if (gameObject.name == "player2coins" && collider.gameObject.name == "player1attack")
        {
            takeHealthOff();
            collider.gameObject.GetComponent<playerInfo>().kills += 1;

        }
    }



    void OnTriggerEnter2D(Collider2D collider)
    {
        shotScript shot = collider.gameObject.GetComponent<shotScript>();
        if (shot != null){
            // same/other  team
            if (shot.team != team){
                takeHealthOff();
            }
        }
        
    }
}