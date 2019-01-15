using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    private Vector3 newPosition;
    public float move;
    public float maxLeft,maxRight;
    public int health = 3;
    public int coinScore = 0;
    // Use this for initialization
    void Start () {
        newPosition = new Vector3(241.3f,154.1f,-12.1f);
	}
	
	// Update is called once per frame
	void Update () {
		    
	}

  public void  movementLeft()
    {
        if (maxLeft < transform.position.x)
        {
            newPosition.x -= move;
            gameObject.transform.position = newPosition;
        }
           
            
    }

    public void movementRight()
    {
        if (maxRight > transform.position.x)
        {
            newPosition.x += move;
            gameObject.transform.position = newPosition;
        }
    }
}
