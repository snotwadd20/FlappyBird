using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour 
{
	public float speed = 0;
	public float switchTime = 2;
	private Rigidbody2D rb2d = null;

	// Use this for initialization
	void Awake () 
	{
		rb2d = GetComponent<Rigidbody2D>();
	}//Awake

	void Start()
	{
		rb2d.velocity = Vector2.up * speed;
		InvokeRepeating("Switch", 0, switchTime);
	}//Start

	void Switch()
	{
		rb2d.velocity *= -1;

	}//Switch

	// Update is called once per frame
	void Update () 
	{
		
	}//Update
}//
