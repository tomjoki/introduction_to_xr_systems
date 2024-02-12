using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class LensCameraRotation : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject lens;

    void Update()
    {
        if (mainCamera is not null && lens is not null)
        {
            var lensTransform = transform;
            Vector3 toMainCamera = mainCamera.transform.position - lensTransform.position;
            Quaternion relativeRotation = Quaternion.LookRotation(-toMainCamera, lens.transform.up);
            lensTransform.rotation = relativeRotation;
        }
    }
}