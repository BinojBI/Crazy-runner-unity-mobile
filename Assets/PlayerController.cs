using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("yeah");
	}
	
	// Update is called once per frame
	void Update () {
	//	Debug.Log("Hi i'm A");

	transform.position = new Vector2(4,5);
		 if (Input.GetKeyDown(KeyCode.Space))
        {
            print("space key was pressed");
        }
	}
}
