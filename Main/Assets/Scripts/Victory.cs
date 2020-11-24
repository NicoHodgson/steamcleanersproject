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
            transform.position = new Vector3(62.31f, -.32f, 0);
            rb.velocity = new Vector3(0,0,0);
        }
        if (collide.gameObject.tag == "Goal")
        {
             transform.position = new Vector3(26.8f, -.32f, 0);
             rb.velocity = new Vector3(0,0,0);
        }
        if (collide.gameObject.tag == "Goal3")
        {
            transform.position = new Vector3(107.5f, -.32f, 0);
            rb.velocity = new Vector3(0, 0, 0);
        }
        if (collide.gameObject.tag == "Goal4")
        {
            transform.position = new Vector3(-7, -.32f, 0);
            rb.velocity = new Vector3(0, 0, 0);
        }
    }
}
