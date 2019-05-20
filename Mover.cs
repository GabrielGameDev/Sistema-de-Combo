using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

	public float speed = -5;

	public float flipTime = 10;

	// Use this for initialization
	void Start () {

		InvokeRepeating("Flip", flipTime, flipTime);

	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate(Vector2.right * speed * Time.deltaTime);

	}

	void Flip()
	{
		speed *= -1;
		Vector3 scale = transform.localScale;
		scale.x *= -1;
		transform.localScale = scale;
	}
}
