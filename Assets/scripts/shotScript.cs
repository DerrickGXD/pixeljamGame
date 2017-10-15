using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Shoot component
/// </summary>


public class shotScript : MonoBehaviour {
    //dead points
    public int damage = 1;

    public int team = 1;


	// Use this for initialization
	void Start () {
        //programmed destroy
        Destroy(gameObject, 20); // 20sec
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnDestroy()
    {
        SpecialEffectsHelper.Instance.Explosion(transform.position);
    }
}