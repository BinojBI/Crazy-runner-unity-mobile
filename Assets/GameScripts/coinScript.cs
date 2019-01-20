using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Audio;

public class coinScript : MonoBehaviour {

    public int score = 1;
    private Vector3 pos;
    public float speed = 7.5f;
    public float destroyPosition = 138f;
    private TextMeshProUGUI textScore;
    private GameObject ScoreText;
    private GameObject CoinScore;
   
    
    // Use this for initialization
    void Start () {
        pos = transform.position;
        ScoreText = GameObject.FindGameObjectWithTag("coin");
        textScore = ScoreText.GetComponent<TextMeshProUGUI> ();
     

    }
	
	// Update is called once per frame
	void Update () {
        pos.y -= speed * Time.deltaTime;
        transform.position = pos;

        if (gameObject.transform.position.y < destroyPosition)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //player take damage
           
            collision.GetComponent<Move>().coinScore += score;
            

            // ShowScore.yourScore += score;
            Debug.Log(collision.GetComponent<Move>().coinScore);
            textScore.text = collision.GetComponent<Move>().coinScore.ToString();
            Destroy(gameObject);
        }
    }
}
