using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Music : MonoBehaviour {
    
    public AudioSource backMusic;

  

    

    public int sceneCount = 0;
   


    private void Awake()
    {
            DontDestroyOnLoad(backMusic);
           
          
    }

  
    
}
