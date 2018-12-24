using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swipController : MonoBehaviour {

private bool isDraging = false;

	private bool tap,swipRight,swipLeft;

	private Vector2 startTouch, swipDelta;

	public Vector2 SwipDelta{ get{return swipDelta;}} 
	public bool SwipLeft{ get {return swipLeft; }}
	public bool SwipRight{ get {return swipRight; }}

	public bool Tap{get {return tap;}}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
					tap = swipLeft = swipRight = false;

			#region Standalone Inputs
			if(Input.GetMouseButtonDown(0)){
					tap = true;
					startTouch = Input.mousePosition;
					isDraging = true;
			}else if(Input.GetMouseButtonUp(0)){
					isDraging = false;
					 Reset();

			}
			#endregion

			#region Mobile Inputs
			if(Input.touches.Length > 0){
					if(Input.touches[0].phase == TouchPhase.Began){
							tap = true;
							isDraging = true;
							startTouch = Input.touches[0].position;
					}else if(Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled)
					{
						isDraging = false;
						Reset();
					}
			}
			#endregion

			//calculate the distance
			swipDelta = Vector2.zero;
			if(isDraging){
					if(Input.touches.Length >0){
							swipDelta =Input.touches[0].position - startTouch;
					}else if(Input.GetMouseButton(0)){
							swipDelta = (Vector2)Input.mousePosition - startTouch;
					}
			}

			//did we cros the dead zone
			if(swipDelta.magnitude> 125){
					float x = swipDelta.x;
					float y = swipDelta.y;
					if(Mathf.Abs(x) > Mathf.Abs(y)){
							if (x < 0)
							{
								swipLeft = true;
							}else
							{
								swipRight = true;
							}
					}else
					{
						if (y < 0)
							{
								swipLeft = true;
							}else
							{
								swipRight = true;
							}
						
					}
			}
	}

	private void Reset(){
			startTouch = swipDelta = Vector2.zero;
			isDraging = false;
	}
}
