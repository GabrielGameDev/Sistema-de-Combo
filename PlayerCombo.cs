using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombo : MonoBehaviour {

	public Combo[] combos;

	public List<string> currentCombo;

	private Animator anim;

	private bool startCombo;

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
			if(combos[i].hits.Length > currentCombo.Count)
			{
				if (Input.GetButtonDown(combos[i].hits[currentCombo.Count].inputButton))
				{
					if (currentCombo.Count == 0)
					{
						Debug.Log("Primeiro hit foi adicionado");
						PlayHit(combos[i].hits[currentCombo.Count]);
						break;
					}
					else
					{
						bool comboMatch = false;
						for (int y = 0; y < currentCombo.Count; y++)
						{
							if (currentCombo[y] != combos[i].hits[y].inputButton)
							{
								Debug.Log("Input não pertence ao hit atual");
								comboMatch = false;
								break;
							}
							else
							{
								comboMatch = true;
							}
						}

						if (comboMatch)
						{
							Debug.Log("Hit adicionado ao combo");
							PlayHit(combos[i].hits[currentCombo.Count]);
							break;
						}
					}

				}
			}

			
		}
	}

	void PlayHit(Hit hit)
	{
		anim.Play(hit.animation);
		startCombo = true;
		currentCombo.Add(hit.inputButton);
	}

	void ResetCombo()
	{
		startCombo = false;
	}
}
