using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(CameraMovement))]
public class CameraSlowdown : MonoBehaviour
{
    public void Start()
    {
        CcameraSpeed = GetComponent(CameraMovement);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Camer
    }
}
