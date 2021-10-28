using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CarBehavior : MonoBehaviour
{
   public float speed = 3f;
   public Transform _player;
   
   public void Update()
   {
      transform.position = new Vector2(transform.position.x, _player.position.y * 0.85f);
      
      transform.Translate(Vector3.right * speed * Time.deltaTime);
   }
}
