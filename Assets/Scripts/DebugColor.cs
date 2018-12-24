using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugColor : MonoBehaviour {

    private BaseColor basecolor;

	// Use this for initialization
	void Start () {
        basecolor = GetComponent<BaseColor>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            basecolor.isRed = true;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            basecolor.isBlue = true;
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            basecolor.isGreen = true;
        }
    }
}
