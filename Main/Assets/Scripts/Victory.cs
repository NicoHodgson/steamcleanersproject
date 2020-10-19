﻿using System.Collections;
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
        if (collide.gameObject.tag == "Goal")
        {
            transform.position = new Vector3(-6.39f, -.42f, 0);
            rb.velocity = new Vector3(0,0,0);
        }
    }
}
