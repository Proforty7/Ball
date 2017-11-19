using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObs : MonoBehaviour {

	Vector3 pos = new Vector3(0, 5, 0);
	public GameObject obs;
	ObsMovement m;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("spawn", 0, 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate()
	{
		
	}

	void spawn()
	{
		if(Input.GetButton("Fire1"))
			{
			Instantiate (obs, new Vector3 (Random.Range (-5f, -2f), pos.y, -1), Quaternion.identity);
			//pos = m.pos;
			Debug.Log (pos);
			}
	
	}
}
