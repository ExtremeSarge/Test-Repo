using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float moveSpeed = 5f;
    private float rotationSpeed = 120f;
    private float jumpForce = 7f;

    private Rigidbody rb;
    private bool isGrounded=true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; // Prevent rotation due to physics
    }

    // Update is called once per frame
    void Update()
    {
        // W and S for forward and backward movement
        float moveInput= Input.GetAxis("Vertical");
        Vector3 moveDirection = transform.forward * moveInput *moveSpeed;
        rb.velocity = new Vector3(moveDirection.x, rb.velocity.y, moveDirection.z);

        // A and D for rotation
        float rotationInput = Input.GetAxis("Horizontal");
        transform.Rotate(0.0f, rotationInput * rotationSpeed * Time.deltaTime, 0.0f);
    }
}
