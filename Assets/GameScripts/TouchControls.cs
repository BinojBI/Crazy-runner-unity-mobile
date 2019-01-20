using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TouchControls : MonoBehaviour {

    public Vector2 startTouch, endTouch;
    public bool leftSwip, rightSwip = false;
    public bool tap,getFinger = false;


    public Move move;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

   

            if (Input.touches.Length > 0)
            {
                if (Input.touches[0].phase == TouchPhase.Began)
                {
                    tap = true;
                    getFinger = false;
                    startTouch = Input.touches[0].position;
                    //  Debug.Log("startPosition :" + startTouch);



                }
                else if (Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled)
                {
                    getFinger = true;
                    tap = false;
                    endTouch = Input.touches[0].position;
                    // Debug.Log("endPosition :" + endTouch);

                }

                if (tap == false)
                {
                    float direction = startTouch.x - endTouch.x;
                    if (direction < 0)
                    {
                        Debug.Log("direction : right");
                        rightSwip = true;
                        leftSwip = false;
                        move.movementRight();
                    }
                    else if (direction > 0)
                    {
                        Debug.Log("direction : left ");
                        leftSwip = true;
                        rightSwip = false;
                        move.movementLeft();
                    }
                }
            
        }

        
           
       
                
           
         
        
        
    }

    public void playerPosition(float xStart, float xEnd){

        float direction = xStart - xEnd;
        if (direction>0)
        {
            // swip to right
          //  Debug.Log("swip to right");
        }else if (direction<0)
        {
            //swip to left
          //  Debug.Log("swip to left");
        }
    }



}
