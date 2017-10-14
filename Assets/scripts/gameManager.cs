using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour {
    public float scoreTeam1 = 0;
    public float scoreTeam2 = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void addScore(int team, float value) {
        if (team == 1)
        {
            scoreTeam1 += value;
            GameObject.FindGameObjectWithTag("scoreTeam1").GetComponent<Text>().text = "GHOSTS: " + scoreTeam1;
        }
        else
        {
            scoreTeam2 += value;
            GameObject.FindGameObjectWithTag("scoreTeam2").GetComponent<Text>().text = "PUMPKINS: " + scoreTeam2;

        }
    }
}
