using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour {
    public int scoreTeam1 = 0;
    public int scoreTeam2 = 0;


    // Use this for initialization
    void Start () {
        PlayerPrefs.SetInt("team1kills", 0);
        PlayerPrefs.SetInt("team2kills", 0);

    }

    // Update is called once per frame
    void Update () {
		
	}


    public void addScore(int team, int value) {
        if (team == 1)
        {
            scoreTeam1 += value;
            GameObject.FindGameObjectWithTag("scoreTeam1").GetComponent<Text>().text = "GHOSTS: " + scoreTeam1;
            PlayerPrefs.SetInt("team1kills", scoreTeam1);

        }
        else
        {
            scoreTeam2 += value;
            GameObject.FindGameObjectWithTag("scoreTeam2").GetComponent<Text>().text = "PUMPKINS: " + scoreTeam2;
            PlayerPrefs.SetInt("team2kills", scoreTeam2);
        }
    }
}
