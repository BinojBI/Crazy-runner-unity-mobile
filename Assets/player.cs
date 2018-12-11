using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
	private Vector3 targetPos;
	public float yIncremental;
	
	public float maxright;
	public float maxleft;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

			//transform.position = Vector2.MoveTowards(targetPos,transform.position, speed* Time.deltaTime );

		if (Input.GetKeyDown(KeyCode.D) && transform.position.x < maxright)
		{
			targetPos = new Vector3(transform.position.x + yIncremental ,transform.position.y, transform.position.z );
			transform.position = targetPos;	

		}else if(Input.GetKeyDown(KeyCode.A) && transform.position.x > maxleft)
		{
			targetPos = new Vector3(transform.position.x - yIncremental ,transform.position.y, transform.position.z );
			transform.position = targetPos;
		}
	}


}
