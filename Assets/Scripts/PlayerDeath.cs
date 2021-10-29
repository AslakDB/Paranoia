using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerDeath : MonoBehaviour
{
   // public FadeInOut _fade;


    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Damage"))
        {
            //_fade.FadeInOut();
            SceneManager.LoadScene("Game Over Scene");
        }
    }
}
