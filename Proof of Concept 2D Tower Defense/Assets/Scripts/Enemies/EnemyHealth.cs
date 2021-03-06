﻿using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	private Animator animDie;

	[SerializeField]
	private float EnemyDamage = 7;
	[SerializeField]
	private float enemyCurHealth = 20;
	[SerializeField]
	private float maxHealth = 20;
	public float waitSeconds;

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
		animDie = GetComponent<Animator>();
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

		if(enemyCurHealth <= 1){
			this.Destroy(healthbar);
			this.Destroy(GetComponent<EnemyBehaviour>());
			this.Destroy(GetComponent<PolygonCollider2D>());
			this.animDie.SetBool("Die", true);
			this.StartCoroutine(Die());

			//Destroy();
		}


	}
	public void SetHealthBar(float myHealth){
		//myHealth value 0-1 , 
		healthbar.transform.localScale = new Vector3(myHealth,healthbar.transform.localScale.y,healthbar.transform.localScale.z);
	}
	IEnumerator Die(){
		yield return new WaitForSeconds(waitSeconds);
		Destroy(this.gameObject);
	}
}
