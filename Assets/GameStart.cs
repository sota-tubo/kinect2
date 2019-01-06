using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStart : MonoBehaviour {

    [SerializeField]
    private touch touch1, touch2;
    [SerializeField]
    private Slider slider;

    private AudioSource audio;

	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {

        //if (Input.GetKeyDown(KeyCode.Return))
		if (touch1.touches == true && touch2.touches == true)
        {
            slider.value += Time.deltaTime;
            if (slider.value >= 1.0f)
            {
                audio.Play();
                SceneManager.LoadScene("test");
            }
        }
	}
}
