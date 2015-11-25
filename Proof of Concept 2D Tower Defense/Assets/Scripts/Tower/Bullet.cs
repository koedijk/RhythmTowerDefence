using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
	//snelheid van de kogel
	[SerializeField]
	private float bulletDamage = 5;
	public float BulletDamage{ get{ return bulletDamage; } set{ bulletDamage = value;} } 



	private float speed = 5;
	public float Speed{ get{ return speed; }set{ speed = value;} }
	EnemyHealth enemyHealth;



	void Start(){
		GameObject objUpgrades = GameObject.Find("UpgradeUI");
		Upgrades upgrades = objUpgrades.GetComponent<Upgrades>();
		BulletDamage = upgrades.UpgradeBulletDamage;
		Speed = upgrades.UpgradeBulletSpeed;
	}

	void Update()
	{
		Vector3 movementVector = this.transform.right * (Speed * Time.deltaTime);
		this.transform.position += movementVector;
		Invoke("killme", 5f);
		Upgrade();
	}

	void OnTriggerEnter2D(Collider2D other)
	{	
		enemyHealth = other.GetComponent<EnemyHealth>();
		if(other.gameObject.tag == "Enemy"){
			enemyHealth.enemyHealth -= bulletDamage;
			Destroy(this.gameObject);

		}
		else if(other.gameObject.tag == "Floor"){
			Destroy(this.gameObject);
		}

	}
	
	void killme()
	{
		Destroy(this.gameObject);
	}

	void Upgrade(){
		GameObject objUpgrades = GameObject.Find("UpgradeUI");
		Upgrades upgrades = objUpgrades.GetComponent<Upgrades>();
		if(upgrades.UpgradeDamage == true){

			BulletDamage = upgrades.UpgradeBulletDamage;
			Debug.Log(bulletDamage);
			upgrades.UpgradeDamage = false;
			
		}
		if(upgrades.UpgradeSpeed == true){

			Speed = upgrades.UpgradeBulletSpeed;
			upgrades.UpgradeSpeed = false;
		}

	}
}

