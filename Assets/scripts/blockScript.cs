using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        // is it a shot?
        shotScript shot = collider.gameObject.GetComponent<shotScript>();
        if (shot != null)
        {
            Destroy(shot.gameObject);
        }
        
    }
}
