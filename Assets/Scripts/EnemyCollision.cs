using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour {

    private GameObject sphere;
    private GameObject scoretext;
    private Vis_score vscore;
    [SerializeField]
    private int scorenum; //スコア
    private int bonus;
    private AudioSource[] audio;

	// Use this for initialization
	void Start () {
        sphere = GameObject.Find("New Sprite");
        scoretext = GameObject.Find("ScoreText");
        vscore = scoretext.GetComponent<Vis_score>();
        scorenum = 50;
        bonus = 50;
        audio = GetComponents<AudioSource>();
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
            if (sphere.gameObject.GetComponent<Renderer>().material.color != Color.white)
            {
                if (gameObject.tag == "White")
                {
                    Destroy(gameObject);
                    audio[0].Play();
                    vscore.scoreup(scorenum);
                }
                else if (gameObject.tag == "Red" && sphere.gameObject.GetComponent<Renderer>().material.color != Color.red && sphere.gameObject.GetComponent<Renderer>().material.color != Color.magenta && sphere.gameObject.GetComponent<Renderer>().material.color != Color.yellow)
                {
                    Destroy(gameObject);
                    audio[0].Play();
                    vscore.scoreup(scorenum);

                    if (sphere.gameObject.GetComponent<Renderer>().material.color == Color.cyan)
                    {
                        vscore.scoreup(bonus);
                    }

                }
                else if (gameObject.tag == "Blue" && sphere.gameObject.GetComponent<Renderer>().material.color != Color.blue && sphere.gameObject.GetComponent<Renderer>().material.color != Color.cyan && sphere.gameObject.GetComponent<Renderer>().material.color != Color.magenta)
                {
                    Destroy(gameObject);
                    audio[0].Play();
                    vscore.scoreup(scorenum);

                    if (sphere.gameObject.GetComponent<Renderer>().material.color == Color.yellow)
                    {
                        vscore.scoreup(bonus);
                    }

                }
                else if (gameObject.tag == "Green" && sphere.gameObject.GetComponent<Renderer>().material.color != Color.green && sphere.gameObject.GetComponent<Renderer>().material.color != Color.cyan && sphere.gameObject.GetComponent<Renderer>().material.color != Color.yellow)
                {
                    Destroy(gameObject);
                    audio[0].Play();
                    vscore.scoreup(scorenum);

                    if (sphere.gameObject.GetComponent<Renderer>().material.color == Color.magenta)
                    {
                        vscore.scoreup(bonus);
                    }

                }
                else if (gameObject.tag == "Cyan" && sphere.gameObject.GetComponent<Renderer>().material.color == Color.red)
                {
                    Destroy(gameObject);
                    audio[0].Play();
                    vscore.scoreup(scorenum);
                }
                else if (gameObject.tag == "Magenta" && sphere.gameObject.GetComponent<Renderer>().material.color == Color.green)
                {
                    Destroy(gameObject);
                    audio[0].Play();
                    vscore.scoreup(scorenum);
                }
                else if (gameObject.tag == "Yellow" && sphere.gameObject.GetComponent<Renderer>().material.color == Color.blue)
                {
                    Destroy(gameObject);
                    audio[0].Play();
                    vscore.scoreup(scorenum);
                }
            }
        }

        if (collision.gameObject.tag == "Body")
        {
            Destroy(gameObject);
            audio[1].Play();
            vscore.scoreup((-scorenum));
        }

    }

   
}
