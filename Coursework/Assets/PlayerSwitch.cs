using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerSwitch : MonoBehaviour
{
    public InputActionReference action;
    public GameObject player;
    public Vector3 initial = new Vector3(0, 0, 0);
    public Vector3 externalView = new Vector3(0, 20, -50);
    void Start()
    {
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            if (player.transform.position == initial)
            {
                player.transform.SetPositionAndRotation(externalView, player.transform.rotation);
            } else {
                player.transform.SetPositionAndRotation(initial, player.transform.rotation);
            }
        };
    }
}
