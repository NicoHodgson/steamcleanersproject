using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collide)
    {
        if (collide.gameObject.tag == "Goal2")
        {
            transform.position = new Vector3(62.31f, -1.56f, 0);
            rb.velocity = new Vector3(0,0,0);
        }
        if (collide.gameObject.tag == "Goal")
        {
             transform.position = new Vector3(25f, -.30f, 0);
             rb.velocity = new Vector3(0,0,0);
        }
    }
}
