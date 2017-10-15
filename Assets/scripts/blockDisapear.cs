using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockDisapear : MonoBehaviour {


    public string nameBlocDisapear = "disappear1";
    GameObject bloc;
    // Use this for initialization
    void Start () {
        bloc = GameObject.Find(nameBlocDisapear);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        bloc.SetActive(false);

    }
    void OnTriggerExit2D(Collider2D collider)
    {
        bloc.SetActive(true);
    }

}
