using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

//BP Gaandu hai :)


    private GameObject player;
    public Material bg;
    float k;
	// Use this for initialization
	void Start () {
        bg.mainTextureOffset = new Vector2(bg.mainTextureOffset.x, 0);
        player = GameObject.Find("Player");
        k = 0.005f;
        InvokeRepeating("incSpeed", 5, 5);
        // bg = GameObject.Find("Background").GetComponent<Material>();
    }
	
	// Update is called once per frame
	void Update () {
        
		if(Input.GetButton("Fire1"))
        {
            Debug.Log(k);
            bg.mainTextureOffset = new Vector2(bg.mainTextureOffset.x, bg.mainTextureOffset.y + k);
           // player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 0.02f, player.transform.position.z);
        }
	}

    private void incSpeed()
    {
        k += 0.0005f;
    }
}
