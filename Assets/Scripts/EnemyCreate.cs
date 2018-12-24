using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCreate : MonoBehaviour {

    [SerializeField]
    private Transform up, left, right;
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
    GameObject refObj;

    [SerializeField]
    private Timer timer;

    private bool cancreate;

	// Use this for initialization
	void Start () {

        upArrow.enabled = false;
        leftArrow.enabled = false;
        rightArrow.enabled = false;

        refObj = GameObject.Find("Time");
        cancreate = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Timer.timeleft <= 0)
        {
            upArrow.enabled = false;
            leftArrow.enabled = false;
            rightArrow.enabled = false;
        }
	}

    private void FixedUpdate()
    {

        if (Timer.isEnd != false)
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
            if (Timer.timeleft >= 20.0f)
            {
                int random = Random.Range(0, 3);
                switch (random)
                {
                    case 0:
                        Instantiate(enemy, up);
                        //Instantiate(alert, Alup);
                        break;
                    case 1:
                        Instantiate(enemy, left);
                        //Instantiate(alert, Alleft);
                        break;
                    case 2:
                        Instantiate(enemy, right);
                        //Instantiate(alert, Alright);
                        break;
                    default:
                        break;
                }
                StartCoroutine("arrow", random);
            }
            else if (Timer.timeleft >= 10.0f && Timer.timeleft < 20.0f)
            {
                int random1 = Random.Range(0, 4);
                int random2 = Random.Range(0, 3);
                switch (random1)
                {

                    case 0:
                        switch (random2)
                        {
                            case 0:
                                Instantiate(enemy, up);
                                //Instantiate(alert, Alup);
                                break;
                            case 1:
                                Instantiate(enemy, left);
                                //Instantiate(alert, Alleft);
                                break;
                            case 2:
                                Instantiate(enemy, right);
                                //Instantiate(alert, Alright);
                                break;
                            default:
                                break;
                        }
                        StartCoroutine("arrow", random2);
                        break;

                    case 1:
                        switch (random2)
                        {
                            case 0:
                                Instantiate(enemy1, up);
                                //Instantiate(alert, Alup);
                                break;
                            case 1:
                                Instantiate(enemy1, left);
                                //Instantiate(alert, Alleft);
                                break;
                            case 2:
                                Instantiate(enemy1, right);
                                //Instantiate(alert, Alright);
                                break;
                            default:
                                break;
                        }
                        StartCoroutine("arrow", random2);
                        break;

                    case 2:
                        switch (random2)
                        {
                            case 0:
                                Instantiate(enemy2, up);
                                //Instantiate(alert, Alup);
                                break;
                            case 1:
                                Instantiate(enemy2, left);
                                //Instantiate(alert, Alleft);
                                break;
                            case 2:
                                Instantiate(enemy2, right);
                                //Instantiate(alert, Alright);
                                break;
                            default:
                                break;
                        }
                        StartCoroutine("arrow", random2);
                        break;

                    case 3:
                        switch (random2)
                        {
                            case 0:
                                Instantiate(enemy3, up);
                                //Instantiate(alert, Alup);
                                break;
                            case 1:
                                Instantiate(enemy3, left);
                                //Instantiate(alert, Alleft);
                                break;
                            case 2:
                                Instantiate(enemy3, right);
                                //Instantiate(alert, Alright);
                                break;
                            default:
                                break;
                        }
                        StartCoroutine("arrow", random2);
                        break;

                    default:
                        break;
                }
            }
            else if (Timer.timeleft >= 0f && Timer.timeleft < 10.0f)
            {
                int random3 = Random.Range(0, 7);
                int random4 = Random.Range(0, 3);
                switch (random3)
                {

                    case 0:
                        switch (random4)
                        {
                            case 0:
                                Instantiate(enemy, up);
                                //Instantiate(alert, Alup);
                                break;
                            case 1:
                                Instantiate(enemy, left);
                                //Instantiate(alert, Alleft);
                                break;
                            case 2:
                                Instantiate(enemy, right);
                                //Instantiate(alert, Alright);
                                break;
                            default:
                                break;
                        }
                        StartCoroutine("arrow", random4);
                        break;

                    case 1:
                        switch (random4)
                        {
                            case 0:
                                Instantiate(enemy1, up);
                                //Instantiate(alert, Alup);
                                break;
                            case 1:
                                Instantiate(enemy1, left);
                                //Instantiate(alert, Alleft);
                                break;
                            case 2:
                                Instantiate(enemy1, right);
                                //Instantiate(alert, Alright);
                                break;
                            default:
                                break;
                        }
                        StartCoroutine("arrow", random4);
                        break;

                    case 2:
                        switch (random4)
                        {
                            case 0:
                                Instantiate(enemy2, up);
                                //Instantiate(alert, Alup);
                                break;
                            case 1:
                                Instantiate(enemy2, left);
                                //Instantiate(alert, Alleft);
                                break;
                            case 2:
                                Instantiate(enemy2, right);
                                //Instantiate(alert, Alright);
                                break;
                            default:
                                break;
                        }
                        StartCoroutine("arrow", random4);
                        break;

                    case 3:
                        switch (random4)
                        {
                            case 0:
                                Instantiate(enemy3, up);
                                //Instantiate(alert, Alup);
                                break;
                            case 1:
                                Instantiate(enemy3, left);
                                //Instantiate(alert, Alleft);
                                break;
                            case 2:
                                Instantiate(enemy3, right);
                                //Instantiate(alert, Alright);
                                break;
                            default:
                                break;
                        }
                        StartCoroutine("arrow", random4);
                        break;

                    case 4:
                        switch (random4)
                        {
                            case 0:
                                Instantiate(enemy4, up);
                                //Instantiate(alert, Alup);
                                break;
                            case 1:
                                Instantiate(enemy4, left);
                                //Instantiate(alert, Alleft);
                                break;
                            case 2:
                                Instantiate(enemy4, right);
                                //Instantiate(alert, Alright);
                                break;
                            default:
                                break;
                        }
                        StartCoroutine("arrow", random4);
                        break;

                    case 5:
                        switch (random4)
                        {
                            case 0:
                                Instantiate(enemy5, up);
                                //Instantiate(alert, Alup);
                                break;
                            case 1:
                                Instantiate(enemy5, left);
                                //Instantiate(alert, Alleft);
                                break;
                            case 2:
                                Instantiate(enemy5, right);
                                //Instantiate(alert, Alright);
                                break;
                            default:
                                break;
                        }
                        StartCoroutine("arrow", random4);
                        break;

                    case 6:
                        switch (random4)
                        {
                            case 0:
                                Instantiate(enemy6, up);
                                //Instantiate(alert, Alup);
                                break;
                            case 1:
                                Instantiate(enemy6, left);
                                //Instantiate(alert, Alleft);
                                break;
                            case 2:
                                Instantiate(enemy6, right);
                                //Instantiate(alert, Alright);
                                break;
                            default:
                                break;
                        }
                        StartCoroutine("arrow", random4);
                        break;

                    default:
                        break;
                }
            }
        }


        float wait = Random.Range(3f, 5f);
        yield return new WaitForSeconds(wait);

        cancreate = true;

    }

    IEnumerator arrow(int arrownum)
    {
        switch (arrownum)
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

        yield return new WaitForSeconds(1.0f);

        switch (arrownum)
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

        yield return new WaitForSeconds(1.0f);

        switch (arrownum)
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

        yield return new WaitForSeconds(1.0f);

        switch (arrownum)
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
}
