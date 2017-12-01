using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public Material bg;
    private Transform playerTransform;
    float k;
    public float factor;
    Vector2 origin, target;
	private Vector2 pos;

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

        
		if (Input.GetButton ("Fire1")) {
			Time.timeScale = 1;
			playerTransform.Rotate (0, 0, 50);
			newPosition = Input.mousePosition;
			pos = Camera.main.ScreenToWorldPoint (newPosition);
		} 
		else 
		{
			playerTransform.Rotate (0, 0, 1);
			slowMo ();
		}

		playerTransform.transform.position = new Vector3 (pos.x * factor, -2.45f, -2);
		bg.mainTextureOffset = new Vector2 (bg.mainTextureOffset.x, bg.mainTextureOffset.y + k);
        if(playerTransform.transform.position.x > 3)
        {
            playerTransform.transform.position = new Vector3(3, -2.45f, -2);
        }
        if(playerTransform.transform.position.x < -3)
        {
            playerTransform.transform.position = new Vector3(-3, -2.45f, -2);
        }

    }

	private void slowMo()
	{
		Time.timeScale = 0.1f;
		//Time.fixedDeltaTime = Time.fixedDeltaTime * Time.timeScale * 0.001f;
	}
    private void incSpeed()
    {
        k += 0.0005f;
    }
}
