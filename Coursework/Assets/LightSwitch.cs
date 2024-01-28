using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class LightSwitch : MonoBehaviour
{
    public Light light;
    public InputActionReference action;
    void Start()
    {
        light = GetComponent<Light>();
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            light.color = new Color(1, 0, 1, 1);
        };
    }


    void Update()
    {
        
    }
}
