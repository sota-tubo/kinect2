using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCreate : MonoBehaviour {

    [SerializeField]
    private Transform up, left, right; //出現位置
    [SerializeField]
    //private Transform Alup, Alleft, Alright; //出現場所
    private Image upArrow, leftArrow, rightArrow; //出現場所
	[SerializeField]
	private GameObject alert;
    [SerializeField]
    private GameObject enemy;
    [SerializeField]
    private GameObject enemy1;
    [SerializeField]
    private GameObject enemy2;
    [SerializeField]
    private GameObject enemy3;
    [SerializeField]
    private GameObject enemy4;
    [SerializeField]
    private GameObject enemy5;
    [SerializeField]
    private GameObject enemy6;//敵

    private Timer timer;

    private bool cancreate;

	// Use this for initialization
	void Start () {

        upArrow.enabled = false;
        leftArrow.enabled = false;
        rightArrow.enabled = false;

        timer = GameObject.Find("Time").GetComponent<Timer>();
        cancreate = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (timer.timeleft <= 0)
        {
            upArrow.enabled = false;
            leftArrow.enabled = false;
            rightArrow.enabled = false;

            cancreate = true;
        }
	}

    private void FixedUpdate()
    {

        if (timer.isEnd != false)
        {

            if (cancreate == true)
            {
                cancreate = false;
                StartCoroutine("Create");
            }

        }

    }

    IEnumerator Create()
    {
        if (timer.canStart == true)
        {
            int random1, random2;
            if (timer.timeleft >= 20.0f)
            {
                random1 = 0;
                random2 = Random.Range(0, 3);

                EneInst(random1, random2);
                StartCoroutine("arrow", random2);
            }
            else if (timer.timeleft >= 10.0f && timer.timeleft < 20.0f)
            {
                random1 = Random.Range(0, 4);
                random2 = Random.Range(0, 3);

                EneInst(random1, random2);
                StartCoroutine("arrow", random2);
            }
            else if (timer.timeleft >= 0f && timer.timeleft < 10.0f)
            {
                random1 = Random.Range(0, 7);
                random2 = Random.Range(0, 3);

                EneInst(random1, random2);
                StartCoroutine("arrow", random2);
            }
        }


        float wait = Random.Range(3f, 5f);
        yield return new WaitForSeconds(wait);

        cancreate = true;

    }

    IEnumerator arrow(int arrownum)
    {
        arrowtrue(arrownum);

        yield return new WaitForSeconds(1.0f);

        arrowfalse(arrownum);

        yield return new WaitForSeconds(1.0f);

        arrowtrue(arrownum);

        yield return new WaitForSeconds(1.0f);

        arrowfalse(arrownum);
    }

    private void arrowtrue(int arrowrand)
    {
        switch (arrowrand)
        {
            case 0:
                upArrow.enabled = true;
                break;
            case 1:
                leftArrow.enabled = true;
                break;
            case 2:
                rightArrow.enabled = true;
                break;
            default:
                break;
        }
    }

    private void arrowfalse (int arrowrand)
    {
        switch (arrowrand)
        {
            case 0:
                upArrow.enabled = false;
                break;
            case 1:
                leftArrow.enabled = false;
                break;
            case 2:
                rightArrow.enabled = false;
                break;
            default:
                break;
        }
    }

    private void EneInst(int rand1, int rand2)
    {
        switch (rand1)
        {
            case 0:
                switch (rand2)
                {
                    case 0:
                        Instantiate(enemy, up);
                        break;
                    case 1:
                        Instantiate(enemy, left);
                        break;
                    case 2:
                        Instantiate(enemy, right);
                        break;
                    default:
                        break;
                }
                StartCoroutine("arrow", rand2);
                break;

            case 1:
                switch (rand2)
                {
                    case 0:
                        Instantiate(enemy1, up);
                        break;
                    case 1:
                        Instantiate(enemy1, left);
                        break;
                    case 2:
                        Instantiate(enemy1, right);
                        break;
                    default:
                        break;
                }
                StartCoroutine("arrow", rand2);
                break;

            case 2:
                switch (rand2)
                {
                    case 0:
                        Instantiate(enemy2, up);
                        break;
                    case 1:
                        Instantiate(enemy2, left);
                        break;
                    case 2:
                        Instantiate(enemy2, right);
                        break;
                    default:
                        break;
                }
                StartCoroutine("arrow", rand2);
                break;

            case 3:
                switch (rand2)
                {
                    case 0:
                        Instantiate(enemy3, up);
                        break;
                    case 1:
                        Instantiate(enemy3, left);
                        break;
                    case 2:
                        Instantiate(enemy3, right);
                        break;
                    default:
                        break;
                }
                StartCoroutine("arrow", rand2);
                break;

            case 4:
                switch (rand2)
                {
                    case 0:
                        Instantiate(enemy4, up);
                        break;
                    case 1:
                        Instantiate(enemy4, left);
                        break;
                    case 2:
                        Instantiate(enemy4, right);
                        break;
                    default:
                        break;
                }
                StartCoroutine("arrow", rand2);
                break;

            case 5:
                switch (rand2)
                {
                    case 0:
                        Instantiate(enemy5, up);
                        break;
                    case 1:
                        Instantiate(enemy5, left);
                        break;
                    case 2:
                        Instantiate(enemy5, right);
                        break;
                    default:
                        break;
                }
                StartCoroutine("arrow", rand2);
                break;

            case 6:
                switch (rand2)
                {
                    case 0:
                        Instantiate(enemy6, up);
                        break;
                    case 1:
                        Instantiate(enemy6, left);
                        break;
                    case 2:
                        Instantiate(enemy6, right);
                        break;
                    default:
                        break;
                }
                StartCoroutine("arrow", rand2);
                break;

            default:
                break;
        }
    }
}
