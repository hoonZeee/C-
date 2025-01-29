using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    float Speed = 60f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, Time.deltaTime * Speed, 0f);
    }
}
