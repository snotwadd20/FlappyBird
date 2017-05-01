using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour 
{
	public float speed = 2;
	public float force = 300;

	private Rigidbody2D rb2d = null;

	// Use this for initialization
	void Awake () 
	{
		rb2d = GetComponent<Rigidbody2D>();
	}//Awake

	void Start()
	{
		rb2d.velocity = Vector2.right * speed;
	}//Start

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			rb2d.AddForce(Vector2.up * force);
		}//if
	}//Update
}//
