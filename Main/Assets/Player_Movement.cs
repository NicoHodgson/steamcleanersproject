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

    //Put non physics based movement in here
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            buttonPressed = RIGHT;


        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            buttonPressed = LEFT;


        }
        else
        {
            buttonPressed = null;
        }

    }

    //Put physica based movement in here
    private void FixedUpdate()
    {
        if (buttonPressed == RIGHT)
        {

        }
        else if (buttonPressed == LEFT)
        {

        }
        else
        {

        }
    }
}
