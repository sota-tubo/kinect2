using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mixTouch : MonoBehaviour {

    public bool mix { get; private set; }

	// Use this for initialization
	void Start () {
        mix = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Color")
        {
            mix = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Color")
        {
            mix = false;
        }
    }

}
