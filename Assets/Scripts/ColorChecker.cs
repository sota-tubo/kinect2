using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChecker : MonoBehaviour {

	public List<GameObject> touchColor { get; set; }

	public int touchCount { get; set; }

	// Use this for initialization
	void Start () {
		touchColor = new List<GameObject>();
		touchCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate()
	{
		if (touchCount > 2)
			touchCount = 2;
		else if (touchCount < 0)
			touchCount = 0;
	}

}
