﻿using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {
	[SerializeField]
	private float EnemyDamage = 7;
	[SerializeField]
	private float enemyCurHealth = 20;
	[SerializeField]
	private float maxHealth = 20;

	public float enemyHealth{
		get
		{
			return enemyCurHealth;
		}
		set
		{
			enemyCurHealth = value;
		}

	}

	public GameObject healthbar;

	// Use this for initialization
	void Start () {

		enemyCurHealth = maxHealth;
		InvokeRepeating("Decreasehealth",1f,0.5f);
	}
	
	// Update is called once per frame
	void Update () {
		Decreasehealth();
	}



	void Decreasehealth(){
		float calculateHealth = enemyCurHealth / maxHealth;
		SetHealthBar(calculateHealth);

		if(enemyCurHealth <= 0){
			Destroy(this.gameObject);
		}


	}
	public void SetHealthBar(float myHealth){
		//myHealth value 0-1 , 
		healthbar.transform.localScale = new Vector3(myHealth,healthbar.transform.localScale.y,healthbar.transform.localScale.z);
	}
}