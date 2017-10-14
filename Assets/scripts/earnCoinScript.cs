using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class earnCoinScript : MonoBehaviour {

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


    void OnTriggerEnter2D(Collider2D collider) {
        // is it a coin?
        coinScript coin = collider.gameObject.GetComponent<coinScript>();
        if (coin != null) {
            _gm_.addScore(team, coin.value);
            // destroy the coin
            Destroy(coin.gameObject);
        }
    }
}
