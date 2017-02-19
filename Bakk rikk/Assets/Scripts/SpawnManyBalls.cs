using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManyBalls : MonoBehaviour
{
    public int control;
    public GameObject ball;
    // Use this for initialization
    void Update()
    {
        control++;
        if (control % 15 == 0)
        Instantiate(ball);

    }

}
