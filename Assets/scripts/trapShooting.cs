using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//trap that always shoot

public class trapShooting : MonoBehaviour {

    public int team = 10;
    private weaponScript weapon;

    // Use this for initialization
    void Start () {
		
	}
	
	
    void Awake() {
        //getting the weapon
        weapon = GetComponent<weaponScript>();
    }

    void Update() {
        //always fire
        if (weapon != null && weapon.CanAttack)
        {
            weapon.Attack(team);
        }
        

    }


}
