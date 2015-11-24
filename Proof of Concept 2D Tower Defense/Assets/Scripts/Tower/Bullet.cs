using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
	//snelheid van de kogel
	private float bulletDamage = 5;

	public float BulletDamage{ get{ return bulletDamage; } set{ bulletDamage = value;} } 

	public float Speed = 5;
	EnemyHealth enemyHealth;

	void Start(){
		enemyHealth = GameObject.Find("Crab(Clone)").GetComponent<EnemyHealth>();
	}

	void Update()
	{
		Vector3 movementVector = this.transform.right * (Speed * Time.deltaTime);
		this.transform.position += movementVector;
		Invoke("killme", 5f);
	}

	void OnTriggerEnter2D(Collider2D other)
	{	
		enemyHealth = other.GetComponent<EnemyHealth>();
		if(other.gameObject.tag == "Enemy"){
			enemyHealth.enemyHealth -= bulletDamage;
			Destroy(this.gameObject);

		}

	}
	
	void killme()
	{
		Destroy(this.gameObject);
	}
}

