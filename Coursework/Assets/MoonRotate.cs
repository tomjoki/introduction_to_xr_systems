using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonRotate : MonoBehaviour
{
    public GameObject parent;

    public float degreesPerS = 20.0f;
    // Update is called once per frame
    void Update()
    {

        transform.RotateAround(parent.transform.position, Vector3.up, degreesPerS * Time.deltaTime);

    }
}
