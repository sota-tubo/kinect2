using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class returnmenu : MonoBehaviour {
	[SerializeField]
	private touch touch1, touch2;
	[SerializeField]
	private Slider slider;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		//if (Input.GetKeyDown(KeyCode.Return))
		if (touch1.touches == true && touch2.touches == true)
		{
			slider.value += Time.deltaTime;
			if (slider.value >= 1.0f)
				SceneManager.LoadScene("Title");
		}
	}
}
