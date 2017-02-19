using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class VictoryHoleControl : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        //  Destroy(other.gameObject);
        String str = SceneManager.GetActiveScene().name;
        char curScene = str[str.Length - 1];
        int curSceneNum = curScene - '0';
        SceneManager.LoadScene("Scene" + (curSceneNum + 1));
    }


}