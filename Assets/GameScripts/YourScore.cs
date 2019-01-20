using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YourScore : MonoBehaviour {
    public int score;
	// Use this for initialization
	void Start () {
		
	}

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update () {
        //Debug.Log(score);
	}
}
