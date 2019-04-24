using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

	private int damage;
	private bool slowDown;
	private AudioClip hitSound;

	public void SetAttack(Hit hit)
	{
		damage = hit.damage;
		slowDown = hit.slowDown;
		hitSound = hit.hitSound;
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		Damage enemy = other.GetComponent<Damage>();
		if(enemy != null)
		{
			enemy.TakeDamage(damage);
		}
	}
}
