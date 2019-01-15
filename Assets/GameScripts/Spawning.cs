using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour {

    public GameObject[] obstaclePattern;
   

	// Use this for initialization
	void Start () {
        InvokeRepeating("respawning", 0, 3f);
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void respawning()
    {
        int rand = Random.Range(0, obstaclePattern.Length);
        Instantiate(obstaclePattern[rand], transform.position, Quaternion.identity);
    }
}
