using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class menuScript : MonoBehaviour {
    public string NameScene = "Menu";


	// Use this for initialization
	void Start () {
		Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(load);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void load()
    {
        print("hell");
        SceneManager.LoadScene(NameScene);
        
    }
}
