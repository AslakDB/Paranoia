using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjects : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        
        print(other.gameObject.name);
        if (other.gameObject.CompareTag("Obsticle"))
        {
            Destroy(other);
            print("Hellooo");
        }
    }
}
