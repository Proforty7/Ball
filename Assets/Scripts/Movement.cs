using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public Material bg;
    float k;
	// Use this for initialization
	void Start () {
        bg.mainTextureOffset = new Vector2(bg.mainTextureOffset.x, 0);
        k = 0.005f;
        InvokeRepeating("incSpeed", 5, 5);
    }
	
	// Update is called once per frame
	void Update () {
        
		if(Input.GetButton("Fire1"))
        {
            Debug.Log(k);
            bg.mainTextureOffset = new Vector2(bg.mainTextureOffset.x, bg.mainTextureOffset.y + k);
        }
	}

    private void incSpeed()
    {
        k += 0.0005f;
    }
}
