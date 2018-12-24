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
    [SerializeField]
    private mixTouch Ltouch, Rtouch; //左手の判定と右手の判定

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate ()
	{
		if (checker.touchCount >= 2) 
		{
			//if ((0 < singleSlider.value && singleSlider.value <= 2.0f) && (Ltouch == true && Rtouch == true)) 
			//{
				mixSlider.value += Time.deltaTime;

				if (mixSlider.value >= 2.0f && singleSlider.value >= 2.0f) 
				{
					if (checker.touchColor [0] == checker.touchColor [1]) 
					{ /*色の変化なし*/} 
					else if (checker.touchColor [0].name == "Red" || checker.touchColor [1].name == "Red") 
					{
						if (checker.touchColor [1].name == "Blue" || checker.touchColor [0].name == "Blue") 
						{
							sphere.GetComponent<Renderer> ().material.color = Color.magenta;
						}
						else if (checker.touchColor [1].name == "Green" || checker.touchColor [0].name == "Green") 
						{
							sphere.GetComponent<Renderer> ().material.color = Color.yellow;
						}
					} 
					else if (checker.touchColor [0].name == "Blue" || checker.touchColor [1].name == "Blue") 
					{
						if (checker.touchColor [1].name == "Green" || checker.touchColor [1].name == "Green") 
						{
							sphere.GetComponent<Renderer> ().material.color = Color.cyan;
						}
					}
				}
			//}
		}
	}
}
