using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour {

    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI yourScoreText;

    private GameObject display;
    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        // yourScoreText.text = score.ToString();
        // highScoreText.text = highScore.ToString();


        
        yourScoreText.text = GameObject.FindGameObjectWithTag("YourScore").GetComponent<YourScore>().score.ToString();

        if (GameObject.FindGameObjectWithTag("HighScore").GetComponent<HighScore>().highScore < GameObject.FindGameObjectWithTag("YourScore").GetComponent<YourScore>().score )
        {
            GameObject.FindGameObjectWithTag("HighScore").GetComponent<HighScore>().highScore = GameObject.FindGameObjectWithTag("YourScore").GetComponent<YourScore>().score;

        }

        highScoreText.text = GameObject.FindGameObjectWithTag("HighScore").GetComponent<HighScore>().highScore.ToString();
        //  display = GameObject.FindGameObjectWithTag("CoinScore");




    }

    void showScore()
    {
        

    }
}
