using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 15f;
    public float jumpForce = 10f;


    private Rigidbody2D rb;
    private SpriteRenderer renderer;

    private bool isGrounded;
    private Vector2 currentVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        renderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");

        Vector2 inputDirection = new Vector2(moveInput, 0);

        float inputMagnitude = inputDirection.magnitude;
        float calculatedSpeed = moveInput * (moveSpeed * Mathf.Log(1 + inputMagnitude) / Mathf.Log(2));
        rb.velocity = new Vector2(calculatedSpeed, rb.velocity.y);

        isGrounded = rb.IsTouchingLayers(LayerMask.GetMask("Ground"));

        

        if (isGrounded)
        {
            currentVelocity.y = -2f; // Small value to keep the player grounded
        }
        else
        {
            currentVelocity.y += Physics2D.gravity.y * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

}
