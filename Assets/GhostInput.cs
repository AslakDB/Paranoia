using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GhostInput : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f;
    public Vector2 moveVector;
    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        moveVector.x = (float) ((Keyboard.current.aKey.isPressed ? -1.5 : 0f) + (Keyboard.current.dKey.isPressed ? 0.25 : 0f));
        moveVector.y = (Keyboard.current.sKey.isPressed ? 0f : 01f) + (Keyboard.current.wKey.isPressed ? 0f : -1f);
    }
    private void FixedUpdate()
    {
        if (PlayerDeath.deathIsAnimating) return;
        rb.MovePosition(rb.position + moveVector * moveSpeed * Time.fixedDeltaTime);
    }
}
