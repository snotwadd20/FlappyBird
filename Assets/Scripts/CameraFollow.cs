using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour 
{
	public Transform target = null;

	void LateUpdate () 
	{
		//Follow on X-axis, remain steady on others
		transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);
	}//LateUpdate
}//
