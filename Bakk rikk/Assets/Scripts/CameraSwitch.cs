﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CameraSwitch : MonoBehaviour {
    public Camera cam1;
    public Camera cam2;

    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        cam1.enabled = !cam1.enabled;
        cam2.enabled = !cam2.enabled;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
