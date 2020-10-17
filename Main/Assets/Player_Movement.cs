using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player_Movement : MonoBehaviour
{
    public Rigidbody rb;
    public const string LEFT = "left";
    public const string RIGHT = "right";
    public float moveSpeed = 3;
    string buttonpressed;
    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody>();
    }
    //Put physica based movement in here
    private void Update() {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            buttonpressed = LEFT;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            buttonpressed = RIGHT;
        }
        else
        {
            buttonpressed = null;
        }

    }
    private void FixedUpdate()
    {
        if (buttonpressed == RIGHT)
        {
            rb.velocity =new Vector3(moveSpeed * Time.deltaTime, 0, 0);
        }
        else if (buttonpressed == LEFT) {
            rb.velocity = new Vector3(-moveSpeed * Time.deltaTime, 0, 0);
        }
    }
}
