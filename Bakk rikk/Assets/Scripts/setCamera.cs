using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class setCamera : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
    public Camera cam3;

    private void OnTriggerEnter(Collider other)
    {
        cam1.enabled = false;
        cam2.enabled = true;
        cam3.enabled = false;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
