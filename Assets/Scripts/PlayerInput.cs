
using UnityEngine;
using UnityEngine.InputSystem;



public class PlayerInput : MonoBehaviour
{
    public float moveSpeed = 5f;
   public Vector2 moveVector;
   public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        moveVector.x = (Keyboard.current.aKey.isPressed ? -0.25f : 0f) + (Keyboard.current.dKey.isPressed ? 1.5f : 0f);
        moveVector.y = (Keyboard.current.sKey.isPressed ? 0f : 1f) + (Keyboard.current.wKey.isPressed ? 0f : -1f);
    }
    private void FixedUpdate()
    {
        if (PlayerDeath.deathIsAnimating) return;
        rb.MovePosition(rb.position + moveVector * moveSpeed * Time.fixedDeltaTime);
    }
}
