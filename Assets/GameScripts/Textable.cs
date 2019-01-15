using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Textable : MonoBehaviour {
    private TextMeshProUGUI textScore;
    public int score = 1;
    public GameObject ScoreText;
    // Use this for initialization
    void Start () {
        textScore = ScoreText.GetComponent<TextMeshProUGUI>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //player take damage
            collision.GetComponent<Move>().health += score;
            Debug.Log(collision.GetComponent<Move>().health);
            textScore.text = collision.GetComponent<Move>().health.ToString();
            Destroy(gameObject);
        }
    }
}
