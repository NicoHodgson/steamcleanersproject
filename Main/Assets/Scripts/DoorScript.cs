using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(player.GetComponent<PlayerMovement>().hasKey == true)
        {
            Destruction();
        }
    }
    void Destruction()
    {
        Destroy(this.gameObject);
    }
}
