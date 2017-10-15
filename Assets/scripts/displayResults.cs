using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayResults : MonoBehaviour {

    int team1kills;
    int team2kills;
    GameObject game;

    // Use this for initialization
    void Start () {

        team1kills = PlayerPrefs.GetInt("team1kills");
        team2kills = PlayerPrefs.GetInt("team2kills");

        int ghost1kills = PlayerPrefs.GetInt("player1attackkills");
        int ghost1coins = PlayerPrefs.GetInt("player1attackcoins");
        int ghost1death = PlayerPrefs.GetInt("player1attackdeath");

        int ghost2kills = PlayerPrefs.GetInt("player1coinskills");
        int ghost2coins = PlayerPrefs.GetInt("player1coinscoins");
        int ghost2death = PlayerPrefs.GetInt("player1coinsdeath");

        int pumpkin1kills = PlayerPrefs.GetInt("player2attackkills");
        int pumpkin1coins = PlayerPrefs.GetInt("player2attackcoins");
        int pumpkin1death = PlayerPrefs.GetInt("player2attackdeath");

        int pumpkin2kills = PlayerPrefs.GetInt("player2coinskills");
        int pumpkin2coins = PlayerPrefs.GetInt("player2coinscoins");
        int pumpkin2death = PlayerPrefs.GetInt("player2coinsdeath");


        game = GameObject.FindGameObjectWithTag("scoreTeam1");
        game.GetComponent<Text>().text = team1kills + " . " + team2kills;

        GameObject.FindGameObjectWithTag("Ghost1Kill").GetComponent<Text>().text = ghost1kills + " KILLS";
        GameObject.FindGameObjectWithTag("Ghost1Death").GetComponent<Text>().text = ghost1death + " DEATHS";
        GameObject.FindGameObjectWithTag("Ghost2Gold").GetComponent<Text>().text = ghost2coins + " COINS";
        GameObject.FindGameObjectWithTag("Ghost2Death").GetComponent<Text>().text = ghost2death + " DEATHS";

        GameObject.FindGameObjectWithTag("Pumpkin1Kill").GetComponent<Text>().text = pumpkin1kills + " KILLS";
        GameObject.FindGameObjectWithTag("Pumpkin1Death").GetComponent<Text>().text = pumpkin1death + " DEATHS";
        GameObject.FindGameObjectWithTag("Pumpkin2Gold").GetComponent<Text>().text = pumpkin2coins + " COINS";
        GameObject.FindGameObjectWithTag("Pumpkin2Death").GetComponent<Text>().text = pumpkin2death + " DEATHS";



    }

    // Update is called once per frame
    void Update () {
        
    }
}
