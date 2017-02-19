using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class reset : MonoBehaviour
{
    public Camera cam1;
    public int y = 0;

    void Start()
    {
        cam1.enabled = false;
    }

    private void Update()
    {
        y++;
        if (y < 2)
        {
            cam1.enabled = true;
        }
    }

}
