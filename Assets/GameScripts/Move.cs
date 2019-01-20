using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Move : MonoBehaviour {
    private Vector3 newPosition;
    public float move;
    public float maxLeft,maxRight;
    public int health = 3;
    public int coinScore = 0;
    public AudioSource movement;
    public AudioSource aaw;
    public AudioSource hooray;
    public YourScore yourScore;
    // Use this for initialization
   
  
     
  
    void Start () {
        newPosition = new Vector3(241.3f,154.1f,-12.1f);
	}
	
	// Update is called once per frame
	void Update () {
        if (health == 0)
        {
            SceneManager.LoadScene("GameOver");        
        }

        yourScore.score = coinScore;
        

	}

  public void  movementLeft()
    {
        if (maxLeft < transform.position.x)
        {
            newPosition.x -= move;
            gameObject.transform.position = newPosition;
            movement.Play();
        }
           
            
    }

    public void movementRight()
    {
        if (maxRight > transform.position.x)
        {
            newPosition.x += move;
            gameObject.transform.position = newPosition;
            movement.Play();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Aww"))
        {
            aaw.Play();
        }

        if (collision.CompareTag("hooray"))
        {
            hooray.Play();
        }
    }
}
