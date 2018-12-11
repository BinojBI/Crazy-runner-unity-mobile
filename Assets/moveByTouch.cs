using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveByTouch : MonoBehaviour {


public bool lift = false;
private Animator anim;
private void Start() {
	anim = GetComponent<Animator>();
}
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

			switch (touch.phase)
            {
                //When a touch has first been detected, change the message and record the starting position
                case TouchPhase.Began:
                    // Record initial touch position.
                   
                    Debug.Log("began");
					lift = true;
                    break;
					 


				// case TouchPhase.Moved:

				// Debug.Log("move");
                //     break;

				case TouchPhase.Ended:
                    // Report that the touch has ended when it ends
                    Debug.Log("ending");
					lift = false;
                    break;

			}
		}

		if(lift == true){
			anim.Play("lift");
		}

    }
}
