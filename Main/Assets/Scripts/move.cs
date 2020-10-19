using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 1.19f;
    public float displacement = 3;
    public bool Vertical = false;
    public bool Horizantal = false;
    Vector3 pointA;
    Vector3 pointB;

    // Start is called before the first frame update
    void Start()
    {
        if (Horizantal)
        {
            pointA = new Vector3(transform.position.x + displacement, transform.position.y, transform.position.z);
            pointB = new Vector3(transform.position.x - displacement, transform.position.y, transform.position.z);
        }
        else if (Vertical)
        {
            pointA = new Vector3(transform.position.x, transform.position.y + displacement, transform.position.z);
            pointB = new Vector3(transform.position.x, transform.position.y - displacement, transform.position.z);
        }
    }

    // Update is called once per frame
    void Update()
    {
      float time = Mathf.PingPong(Time.time * speed, 1);
      transform.position = Vector3.Lerp(pointA, pointB, time);
    }
}
