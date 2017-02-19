using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class LoadLevel : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            SceneManager.LoadScene("Scene0");
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            SceneManager.LoadScene("Scene1");
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            SceneManager.LoadScene("Scene2");
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            SceneManager.LoadScene("Scene3");
        }
        if (Input.GetKey(KeyCode.Alpha5))
        {
            SceneManager.LoadScene("Scene4");
        }
        if (Input.GetKey(KeyCode.Alpha6))
        {
            SceneManager.LoadScene("Scene5");
        }
        if (Input.GetKey(KeyCode.Alpha7))
        {
            SceneManager.LoadScene("Scene6");
        }
        if (Input.GetKey(KeyCode.Alpha8))
        {
            SceneManager.LoadScene("Scene7");
        }
        if (Input.GetKey(KeyCode.Alpha9))
        {
            SceneManager.LoadScene("Scene8");
        }
        if (Input.GetKey(KeyCode.Alpha0))
        {
            SceneManager.LoadScene("Scene9");
        }
        if (Input.GetKey(KeyCode.B))
        {
            SceneManager.LoadScene("Scene10");
        }
    }


}