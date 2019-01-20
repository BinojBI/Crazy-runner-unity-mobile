using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour {
   

    private void Start()
    {
        

    }

    private void Update()
    {
       
    }

    public void playGame()
    {
        SceneManager.LoadScene("SampleScene");
        
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("GameWindow");
    }

    public void stopMusic()
    {
            Destroy(GameObject.FindWithTag("PlayAgain"));

            Destroy(GameObject.FindWithTag("YourScore"));
            
    }


}
