using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{
    Rigidbody rb;
    private float moveSpeed = 3;

    public const string RIGHT = "right";
    public const string LEFT = "left";

    string buttonPressed;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    //Put physica based movement in here
    private void FixedUpdate()
    {
        if (buttonPressed == RIGHT)
        {
            rb.velocity = new Vector3(moveSpeed, 0, 0);
        }
        else if (buttonPressed == LEFT)
        {
            rb.velocity = new Vector3(-moveSpeed, 0, 0);
        }
        else
        {
            rb.velocity = new Vector3(0, 0, 0);
        }
    }
}
