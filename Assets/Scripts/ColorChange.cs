using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{

    public Slider slider;
	[SerializeField]
	private Slider mixSlider;
	[SerializeField]
	private ColorChecker checker;
	private bool check;
    public GameObject sphere;
	[SerializeField]
	private SpriteRenderer backcolor;
    private AudioSource audio;
    private bool playSE;

    // Use this for initialization
    void Start()
    {
        audio = GetComponent<AudioSource>();
		check = true;
        playSE = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {

    }

	private void OnTriggerEnter(Collider collision)
	{
		if (collision.gameObject.tag == "Hand") 
		{
			if (check == true)
			{
				check = false;
				if (gameObject.name != "White") {
					checker.touchColor.Add (gameObject);
					checker.touchCount++;
				} else {
					check = true;
				}
			}
		}
	}

    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "Hand")
        {

            slider.value += Time.deltaTime;
            
			if (mixSlider.value <= 0f && slider.value >= 2.0f)
			{
                if (playSE == true)
                {
                    playSE = false;
                    audio.Play();
                }

                if (this.gameObject.name == "Green")
				{
					sphere.GetComponent<Renderer>().material.color = Color.green;
				}
				else if (this.gameObject.name == "Red")
				{
					sphere.GetComponent<Renderer>().material.color = Color.red;
				}
				else if (this.gameObject.name == "Blue")
				{
					sphere.GetComponent<Renderer>().material.color = Color.blue;
				}
				else if (this.gameObject.name == "White")
				{
					sphere.GetComponent<Renderer>().material.color = Color.white;
				}
			}
        }
    }

    private void OnTriggerExit(Collider collision)
    {

        if (collision.gameObject.tag == "Hand")
        {
			slider.value = 0;
			check = true;
			checker.touchColor.Remove(gameObject);
			checker.touchCount--;
            mixSlider.value = 0;
            playSE = true;
        }

    }

}
