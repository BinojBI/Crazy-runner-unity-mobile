using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour {
    public Vector3 targetPos;
    public float startY;
    public float endY;
	// Use this for initialization
	void Start () {
        targetPos = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        targetPos.y -= 10f*Time.deltaTime;
        transform.position = targetPos;
       // Debug.Log(transform.position.y);

        if (transform.position.y < endY)
        {
            Vector3 pos = new Vector3(transform.position.x,startY,transform.position.z);
            targetPos = pos;
        }
	}
}
