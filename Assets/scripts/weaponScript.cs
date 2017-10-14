using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//creates shoots


public class weaponScript : MonoBehaviour {
    //variables

    //Projectile Prefab
    public Transform shotPrefab;

    //load time
    public float shootingRate = 0.25f;
    //load
    private float shootCooldown;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
    void Update(){
        if (shootCooldown > 0) {
            shootCooldown -= Time.deltaTime;
        }
    }

    //shoot from an other script

    //create a shoot if possible
    public void Attack(int team) {
        if (CanAttack || !CanAttack) {
            shootCooldown = shootingRate;

            //create an object (from prefabs)
            var shotTransform = Instantiate(shotPrefab) as Transform;

            // Position
            shotTransform.position = transform.position;

            // properties of the script
            shotScript shot = shotTransform.gameObject.GetComponent<shotScript>();
            if (shot != null) {
                shot.team = team;
            }

            //direction of the motion
            moveObjectScript move = shotTransform.gameObject.GetComponent<moveObjectScript>();
            if (move != null) {
                move.direction = this.transform.right; // ici la droite sera le devant de notre objet
            }
        }
    }

    //is weapon loaded?
    public bool CanAttack {
        get {
            return shootCooldown <= 0f;
        }
    }
}

