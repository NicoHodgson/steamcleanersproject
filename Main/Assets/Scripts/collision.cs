using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
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

    private void OnTriggerEnter(Collider other) {
      if(other.gameObject.tag == "Enemy") {
	        transform.position = new Vector3(-6.39f, -0.42f, 0f);
            rb.velocity = new Vector3(0, 0, 0);
	    DeathTextScript.deathAmount += 1;
      }
      else if(other.gameObject.tag == "Level2Enemy") {
      	     transform.position = new Vector3(26.8f, -0.30f, 0f);
             rb.velocity = new Vector3(0, 0, 0);
	     DeathTextScript.deathAmount += 1;
      }
      else if(other.gameObject.tag == "Coin") {
	ScoreTextScript.coinAmount += 1;
	Destroy (other.gameObject);
      }
    }
}
