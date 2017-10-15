using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

 
public class timeScript : MonoBehaviour {

    public int time = 90;
    // Use this for initialization
    void Start () {
        StartCoroutine(timeCoRoutine());
        print(time);
    }
	
	// Update is called once per frame
	void Update () {
        GameObject.FindGameObjectWithTag("Time").GetComponent<Text>().text = time.ToString();

    }

    private IEnumerator timeCoRoutine()
    {
        yield return new WaitForSeconds(1);
        time = time-1;
        
        if (time == 0)
        {

            var traps = GameObject.FindGameObjectsWithTag("trap");
            for (var i = 0; i < traps.Length; i++)
            {
                traps[i].SetActive(false);
            }
            
            var team = GameObject.FindGameObjectsWithTag("Team1");
            for (var i = 0; i < team.Length; i++)
            {
                team[i].SetActive(false);
            }
            team = GameObject.FindGameObjectsWithTag("Team2");
            for (var i = 0; i < team.Length; i++)
            {
                team[i].SetActive(false);
            }

            var objects = GameObject.FindGameObjectsWithTag("shot");
            for (var i = 0; i < objects.Length; i++)
            {
                Destroy(objects[i]);
            }


            GameObject.FindGameObjectWithTag("TimeOutMessage").GetComponent<Text>().text = "TIME OUT!";
            yield return new WaitForSeconds(3);

            //END OF THE GAME
            SceneManager.LoadScene("Results");
        }
        else
        {
            StartCoroutine(timeCoRoutine());
        }
    }
}
