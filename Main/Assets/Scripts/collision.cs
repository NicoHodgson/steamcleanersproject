using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
      if(other.gameObject.name == "Enemy") {
	transform.position = new Vector3(-6.39f, -0.42f, 0f);
      }
    }
}
