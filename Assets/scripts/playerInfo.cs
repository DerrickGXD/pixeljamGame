using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInfo : MonoBehaviour {
    public int team = 1;
    public bool attack = false;
    public int death = 0;
    public int coins = 0;
    public int kills = 0;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        PlayerPrefs.SetInt(gameObject.name + "coins", coins);
        PlayerPrefs.SetInt(gameObject.name + "death", death);
        PlayerPrefs.SetInt(gameObject.name + "kills", kills);

    }



}
