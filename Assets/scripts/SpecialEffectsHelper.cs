using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Particle effect

public class SpecialEffectsHelper : MonoBehaviour {

    public static SpecialEffectsHelper Instance;

    public ParticleSystem fireEffect;
    public ParticleSystem newCoinEffect;

    void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("Multiple instances of SpecialEffectsHelper!");
        }

        Instance = this;
    }



    public void Explosion(Vector3 position)
    {
        instantiate(fireEffect, position);
    }
    public void NewCoin(Vector3 position)
    {
        instantiate(newCoinEffect, position);
    }




    private ParticleSystem instantiate(ParticleSystem prefab, Vector3 position)
    {
        ParticleSystem newParticleSystem = Instantiate(
          prefab,
          position,
          Quaternion.identity
        ) as ParticleSystem;

        // Programmed destroy
        Destroy(
          newParticleSystem.gameObject,
          newParticleSystem.startLifetime
        );

        return newParticleSystem;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}