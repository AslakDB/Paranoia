using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float cameraSpeed;
    void Update()
    {
        if (PlayerDeath.deathIsAnimating) return;
        transform.Translate(Vector3.right * cameraSpeed * Time.deltaTime);
    }
}
