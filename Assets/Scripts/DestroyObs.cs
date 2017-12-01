using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObs : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y <= -6)
			Destroy (gameObject);

	
	}
}
