using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundEffectScript : MonoBehaviour {
    public static soundEffectScript Instance;
    public AudioClip swordSound;
    public AudioClip explosionSound;

    void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("Multiple instances of SoundEffectsHelper!");
        }
        Instance = this;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MakeSwordSound()
    {
        MakeSound(swordSound);
    }
    public void MakeExplosionSound()
    {
        MakeSound(explosionSound);
    }

    private void MakeSound(AudioClip originalClip)
    {
        AudioSource.PlayClipAtPoint(originalClip, transform.position);
    }
}
