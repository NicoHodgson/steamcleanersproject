using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public const string LEFT = "left";
    public const string RIGHT = "right";
    public float moveSpeed = 3;
    string buttonpressed;
    public bool isGrounded;
    public float jumpForce;
    public bool isJumping = false;
    public float maxSpeed = 200f;
    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody>();
    }
    //Put physica based movement in here
    private void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            buttonpressed = LEFT;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            buttonpressed = RIGHT;
        }
        else
        {
            buttonpressed = null;
        }
        if (Input.GetButtonDown("Jump") || Input.GetKey(KeyCode.W))
        {
            isJumping = true;
        }
    }
    private void FixedUpdate()
    {
        if (buttonpressed == RIGHT)
        {
            rb.AddForce(new Vector3(moveSpeed * Time.deltaTime, 0, 0), ForceMode.Impulse);
        }
        else if (buttonpressed == LEFT)
        {
            rb.AddForce(new Vector3(-moveSpeed * Time.deltaTime, 0, 0), ForceMode.Impulse);
        }
        if (isJumping == true && isGrounded == true)
        {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
            isGrounded = false;
            isJumping = false;
        }
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
}
