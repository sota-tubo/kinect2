using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildEnemy : MonoBehaviour {

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
	private GameObject enemy6;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//if(enemy.transform.childCount == 0&&this.transform.parent == null){

		this.transform.parent = GameObject.Find("enemy").transform;

		/*}else if(enemy1.transform.childCount == 0&&this.transform.parent == null){

			this.transform.parent = enemy1.transform;

		}else if(enemy2.transform.childCount == 0&&this.transform.parent == null){

			this.transform.parent = enemy2.transform;

		}else if(enemy3.transform.childCount == 0&&this.transform.parent == null){

			this.transform.parent = enemy3.transform;

		}else if(enemy4.transform.childCount == 0&&this.transform.parent == null){

			this.transform.parent = enemy4.transform;

		}else if(enemy5.transform.childCount == 0&&this.transform.parent == null){

			this.transform.parent = enemy5.transform;

		}else if(enemy6.transform.childCount == 0&&this.transform.parent == null){

			this.transform.parent = enemy6.transform;

		}*/

	}
}
