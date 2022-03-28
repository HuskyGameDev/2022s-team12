using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
	// all can be assigned in unity or code.
	public Transform target;
	public float smoothing;
	public Vector2 maxPosition;
	public Vector2 minPosition;
	
	
	void FixedUpdate () {
		if(transform.position != target.position)
		{
			//sets cameras goal position to the target
			Vector3 targetPosition = new Vector3(target.position.x,target.position.y, transform.position.z);
			//checks x bound which can be set on unity or in code
			targetPosition.x = Mathf.Clamp(targetPosition.x, minPosition.x, maxPosition.x);
			//checks y bound which can be set on unity or in code
			targetPosition.y = Mathf.Clamp(targetPosition.y, minPosition.y, maxPosition.y);
			//moves the camera to the desired position
			transform.position = Vector3.Lerp(transform.position,targetPosition, smoothing);
		}
}

}
	
	