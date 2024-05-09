using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;
    public float groundDrag;
    public float LavaDrag;
    public float airMultiplier;

    [Header("Ground Check")]
    public float playerHeight;
    public LayerMask whatIsGround;
    public LayerMask whatIsLava;
    bool grounded;
    bool InLava;

    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 moveDir;

    Rigidbody rb;

    private void Start () {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void Update () {
        // ground check
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, whatIsGround);

        //Lava check
        InLava = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, whatIsLava);

        MyInput();
        SpeedControl();

        // handle ground drag
        if (grounded)
            rb.drag = groundDrag;
        else
            rb.drag = 0;

        // handle Lava drag
        if (InLava)
            rb.drag = LavaDrag;
        else
            rb.drag = 0;
    }

    private void FixedUpdate () {
        MovePlayer();
    }

    private void MyInput () {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void MovePlayer () {
        // calculate movement direction
        moveDir = orientation.forward * verticalInput + orientation.right * horizontalInput;

        rb.AddForce(moveDir.normalized * moveSpeed * 10f, ForceMode.Force);
    }

    private void SpeedControl () {
        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        //limit vlocity if needed
        if (flatVel.magnitude > moveSpeed) {
            Vector3 limitedVel = flatVel.normalized * moveSpeed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
        }
    }

}
