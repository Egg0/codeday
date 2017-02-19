using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoveBall : MonoBehaviour
{
    public float speed;
    public float maxVelocity = 500;
    private Rigidbody self;


    // Use this for initialization
    void Start()
    {
        self = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Vector: (Left/Right, 0, Forward/backwards) 
        int x = 0;
        int z = 0;
        if (Input.GetKey(KeyCode.W)) z = 1;
        if (Input.GetKey(KeyCode.A)) x = -1;
        if (Input.GetKey(KeyCode.S)) z = -1;
        if (Input.GetKey(KeyCode.D)) x = 1;

        if (Math.Abs(self.velocity.x) < maxVelocity) self.AddForce(new Vector3(x, 0, 0) * speed);
        if (Math.Abs(self.velocity.z) < maxVelocity) self.AddForce(new Vector3(0, 0, z) * speed);
    }
}
