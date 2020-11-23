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
      if(other.gameObject.tag == "Level2Enemy") {
      	     transform.position = new Vector3(25f, -0.42f, 0f);
             rb.velocity = new Vector3(0, 0, 0);
	     DeathTextScript.deathAmount += 1;
      }
        if (other.gameObject.tag == "Level3Enemy")
        {
            transform.position = new Vector3(72.5f, -0.42f, 0f);
            rb.velocity = new Vector3(0, 0, 0);
            DeathTextScript.deathAmount += 1;
        }
            if (other.gameObject.tag == "Coin") {
	ScoreTextScript.coinAmount += 1;
	Destroy (other.gameObject);
      }
    }
}
