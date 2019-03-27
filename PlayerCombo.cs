using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombo : MonoBehaviour {

	public Combo[] combos;

	private Animator anim;

	private void Awake()
	{
		anim = GetComponent<Animator>();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		CheckInputs();

	}

	void CheckInputs()
	{
		for (int i = 0; i < combos.Length; i++)
		{
			if (Input.GetButtonDown(combos[i].hits[0].inputButton))
			{
				PlayHit(combos[i].hits[0]);
				break;
			}
		}
	}

	void PlayHit(Hit hit)
	{
		anim.Play(hit.animation);
	}

	void ResetCombo()
	{

	}
}
