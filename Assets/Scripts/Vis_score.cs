using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vis_score : MonoBehaviour {

    public static int score; //リザルト画面でも表示する（予定）

    private Text text; //スコアを表示するテキスト

	// Use this for initialization
	void Start () {
        score = 0;
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        text.text = score.ToString();
	}

    public void scoreup (int sco)
    {
        score += sco;
    }
}
