﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public Material bg;
    private Transform playerTransform;
    float k;
    public float factor;
    Vector2 origin, target;

    void Awake()
    {
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
    }
    // Use this for initialization
    void Start () {
        bg.mainTextureOffset = new Vector2(bg.mainTextureOffset.x, 0);
        k = 0.005f;
        InvokeRepeating("incSpeed", 5, 5);
    }
	
	// Update is called once per frame
	void Update ()
    {

        Vector2 newPosition;
                
        if(Input.GetButtonDown("Fire1"))
        {
            origin = Input.mousePosition;
            //origin = Camera.main.ScreenToWorldPoint(target);
        }
		else if(Input.GetButton("Fire1"))
        {
           
            newPosition = Input.mousePosition;
            float pos = newPosition.x - origin.x;
            Debug.Log(origin + " " + newPosition + " " + pos);
            playerTransform.transform.position += new Vector3(pos * factor, 0, 0);
            bg.mainTextureOffset = new Vector2(bg.mainTextureOffset.x, bg.mainTextureOffset.y + k);
            
        }
	}

    private void incSpeed()
    {
        k += 0.0005f;
    }
}
