﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlatform : MonoBehaviour {
    public float speed;
    private Rigidbody self;
	
    // Use this for initialization
	void Start () {
        self = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    void FixedUpdate() {
        //Vector: (Left/Right, 0, Forward/backwards) 
        int x = 0;
        int z = 0;
        if (Input.GetKey(KeyCode.W)) z = 1;
        if (Input.GetKey(KeyCode.A)) x = -1;
        if (Input.GetKey(KeyCode.S)) z = -1;
        if (Input.GetKey(KeyCode.D)) x = 1;

        self.AddForce(new Vector3(x, 0, z) * speed);
    }
}
