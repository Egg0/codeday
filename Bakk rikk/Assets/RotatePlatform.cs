using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlatform : MonoBehaviour {
    public Quaternion rotation;
    public float rotateIntensity = 20;
	// Use this for initialization
	void Start () {
       
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(rotateIntensity, 0, 0) * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(-rotateIntensity, 0, 0) * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(new Vector3(0, 0, rotateIntensity) * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(new Vector3(0, 0, -rotateIntensity) * Time.deltaTime, Space.World);
        }

    }
}
