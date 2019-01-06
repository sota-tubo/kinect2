using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mixColor : MonoBehaviour {

	[SerializeField]
	private Slider mixSlider;
	[SerializeField]
	private Slider singleSlider;
	[SerializeField]
	private ColorChecker checker;
	[SerializeField]
	private GameObject sphere;

    private AudioSource audio;
    private bool playSE;

	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
        playSE = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        if (checker.touchColor.Count < 2)
        {
            playSE = true;
        }
        else if (checker.touchColor.Count >= 2)
        {
            mixSlider.value += Time.deltaTime;

            if (mixSlider.value >= 2.0f && singleSlider.value >= 2.0f)
            {
                if (playSE == true)
                {
                    playSE = false;
                    audio.Play();
                }

                if (checker.touchColor[0] == checker.touchColor[1])
                { /*色の変化なし*/}
                else if (checker.touchColor[0].name == "Red" || checker.touchColor[1].name == "Red")
                {
                    if (checker.touchColor[1].name == "Blue" || checker.touchColor[0].name == "Blue")
                    {
                        sphere.GetComponent<Renderer>().material.color = Color.magenta;
                    }
                    else if (checker.touchColor[1].name == "Green" || checker.touchColor[0].name == "Green")
                    {
                        sphere.GetComponent<Renderer>().material.color = Color.yellow;
                    }
                }
                else if (checker.touchColor[0].name == "Blue" || checker.touchColor[1].name == "Blue")
                {
                    if (checker.touchColor[1].name == "Green" || checker.touchColor[1].name == "Green")
                    {
                        sphere.GetComponent<Renderer>().material.color = Color.cyan;
                    }
                }
            }
        }
	}
}
