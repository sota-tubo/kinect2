using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseColor : MonoBehaviour {

    public bool isRed { get; set; }
    public bool isBlue { get; set; }
    public bool isGreen { get; set; }

    private Color changeColor; //変更後のオブジェクトの色
                               // private Color objColor; //現在のオブジェクトの色

    private Renderer objColor;

	// Use this for initialization
	void Start () {
        isRed = false;
        isBlue = false;
        isGreen = false;
        changeColor = Color.white;
        objColor = GetComponent<Renderer>();
        objColor.material.color = changeColor;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(objColor.material.color);
	}

    private void FixedUpdate()
    {
        if (isRed == true)
        {
            isBlue = false;
            isGreen = false;

            changeColor = Color.red;
            //objColor = changeColor;
        }
        else if (isBlue == true)
        {
            isRed = false;
            isGreen = false;

            changeColor = Color.blue;
            //objColor = changeColor;
        }
        else if (isGreen == true)
        {
            isRed = false;
            isBlue = false;

            changeColor = Color.green;
           // objColor = changeColor;
        }
    }
}
