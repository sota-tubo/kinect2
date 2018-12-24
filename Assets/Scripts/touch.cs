using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch : MonoBehaviour {

    public bool touches { get; private set; }


	// Use this for initialization
	void Start () {
        touches = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {

    }

	private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Hand")
        {
            touches = true;
            Debug.Log(touches);
        }
    }

	private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Hand")
        {
            touches = false;
        }
    }
}
