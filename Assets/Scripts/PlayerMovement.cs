using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private float horizontalInput;
    private float verticalInput;
    private Vector2 movement;

    public Rigidbody rb;

    [SerializeField]
    private float speed = 275f;

    // Update is called once per frame
    void Update()
    {
        // Gets player input
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        // Generates the player's direction
        movement = new Vector2(horizontalInput, verticalInput).normalized;
    }

    private void FixedUpdate()
    {
        // Applies player's movement
        rb.velocity = movement * Time.fixedDeltaTime * speed;
    }
}
