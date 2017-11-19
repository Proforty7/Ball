using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsMovement : MonoBehaviour {

	public Vector3 pos;
	private GameObject obj;
	// Use this for initialization
	void Start () {
		
	}


	
	// Update is called once per frame
	void Update () {
		//obj = GameObject.FindGameObjectWithTag ("Obstacle");
		//pos = obj.transform.position;
		if (Input.GetButton ("Fire1"))
			gameObject.transform.position -= new Vector3 (0, 0.03f, 0);
		}

}
