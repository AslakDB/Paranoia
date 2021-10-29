using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerDeath : MonoBehaviour
{
   // public FadeInOut _fade;
   public Animator animator;
   //private static readonly int s_DeathAnimation = Animator.StringToHash("DeathAnimation");
   public static bool deathIsAnimating = false;

   public void Start()
   {
       animator = GetComponent<Animator>();
   }

   public void Death()
   {
       SceneManager.LoadScene("Game Over Scene");
   }

   private void Update()
   {
       if (animator.GetCurrentAnimatorStateInfo(0).IsName("DeathAnimation"))
       {
           deathIsAnimating = true;
       }
       else
       {
           deathIsAnimating = false;
       }
   }

   void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Damage"))
        {
            animator.Play("DeathAnimation");
        }
    }
}
