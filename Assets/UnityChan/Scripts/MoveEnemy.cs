using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour {

	[SerializeField]
	private float speed;

    [SerializeField]
	private GameObject player;

    private Timer timer;

	// Use this for initialization
	void Start () {
		speed = 4.5f;

        timer = GameObject.Find("Time").GetComponent<Timer>();

        //player.transform.position = new Vector3(0f, 0f, 0f);
    }
	
	// Update is called once per frame
	void Update () {
		if (timer.timeleft <= 0f)
        {
            Destroy(gameObject);
        }
	}

	private void FixedUpdate()
	{
		transform.LookAt(player.transform);
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}
}
