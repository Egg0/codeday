using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeTrackerScript : MonoBehaviour {
    public static int lives;

    // Use this for initialization
    void Start () {
        lives = 3;
	}
	
	// Update is called once per frame
	void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

}
