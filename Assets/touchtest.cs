using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchtest : MonoBehaviour {

	private bool tap;
	private Vector2 newPosition;
	private bool isDraging = false;
	
	private Vector2 startTouch,swipDelta;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.touches.Length > 0){
					if(Input.touches[0].phase == TouchPhase.Began){

							
							Debug.Log("touch begans");
							tap = true;
							isDraging = true;
							newPosition = new Vector2(transform.position.x, transform.position.y);
							gameObject.transform.position = newPosition;
							//startTouch = Input.touches[0].position;
							
					}else if(Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled)
					{
						Debug.Log("touch ends");
						isDraging = false;
						//Reset();
						//gameObject.transform.position = swipDelta;
					}
			}

			if(isDraging){
					if(Input.touches.Length >0){
							swipDelta =Input.touches[0].position - startTouch;
							Debug.Log(swipDelta);
							gameObject.transform.position = swipDelta;

					}
			}
	}

		private void Reset(){
			startTouch = swipDelta = Vector2.zero;
			isDraging = false;
	}
}
