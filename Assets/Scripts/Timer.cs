using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    public Text time;
    public float timeleft = 30f;
    public bool isEnd = true;
    public bool canStart { get; set; }
    [SerializeField]
    private int Count = 3;
    private bool counton;

    // Use this for initialization
    void Start () {
		timeleft = timeleft;
        canStart = false;
        counton = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (canStart == false && counton == true)
        {
            counton = false;
            //カウントダウン開始
            StartCoroutine("count", Count);
        }
        else if (canStart == true && timeleft >= 1f)
        {
            time.text = ((int)timeleft).ToString();
            timeleft -= Time.deltaTime;
        }
    }

    void FixedUpdate() {


        if (timeleft <= 0)
        {
            isEnd = false;
            timeleft = 0;
            time.text = "Finish!!";
            Invoke("move", 1.5f);
        }
        else if (timeleft < 1f)
        {
            timeleft = 0;
        }
    }

    private void move()
    {
        SceneManager.LoadScene("Result");
    }

    IEnumerator count(int countnum)
    {
        time.text = countnum.ToString();

        yield return new WaitForSeconds(1.0f);

        Count--;
        if (Count == 0)
        {
            time.text = "Start!!";

            yield return new WaitForSeconds(1.5f);

            canStart = true;
        }
        else
        {
            StartCoroutine("count", Count);
        }
    }

}
