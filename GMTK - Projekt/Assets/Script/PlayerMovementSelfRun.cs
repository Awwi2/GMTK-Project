using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementSelfRun : MonoBehaviour
{
    public float movementSpeed = 5f;
    public Rigidbody2D rb;

    Vector2 movement;

    void Start()
    {
        
    }

    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        // Check if there is no input and set movement vector to zero
        if (inputX == 0 && inputY == 0)
        {
            movement.x = 0f;
            movement.y = 0f;
        }
        else
        {
            // Update the movement direction only if there is a new input
            movement.x = inputX;
            movement.y = inputY;
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement.normalized * movementSpeed * Time.fixedDeltaTime);
    }
}
