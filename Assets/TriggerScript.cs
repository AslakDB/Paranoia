using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    private PlayMusic1 Music1;

    private void Awake()
    {
        Music1 = GetComponent<PlayMusic1>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
            
        if (collider.gameObject.CompareTag("Song1"))
        {
            // if has played return
            Music1.PlaySong1(0);
            // set bool has played
        }
        else if (collider.gameObject.CompareTag("Song2"))
        {
            Music1.PlaySong1(1);
        }
        else if (collider.gameObject.CompareTag("Song3"))
        {
            Music1.PlaySong1(2);
        }
        else
        {
            Music1.PlaySong1(3);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
