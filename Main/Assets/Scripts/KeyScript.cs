using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public bool hasKey = false;


    // Update is called once per frame
    void Update()
    {
        if (hasKey == true)
        {
            Destruction();
        }
    }
    void Destruction()
    {
        Destroy(this.gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            hasKey = true;
        }
    }
}
