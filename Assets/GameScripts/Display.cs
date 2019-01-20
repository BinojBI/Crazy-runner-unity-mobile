using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Display : MonoBehaviour {

    

    public int highScore;
    public int score;



    // Use this for initialization
    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "SampleScene") {
            //score = 0;
            Debug.Log("score zero function working");
        }    
       
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update () {
        



    }

    public void showScore(int score)
    {
            
            if (highScore < score)
            {
                highScore = score;
                ShowScore.highScore = highScore;
                this.score = score;

            }

        Debug.Log("Your score" + score);
        Debug.Log("High score" + ShowScore.highScore);

       
        

    }
}
