using UnityEngine;
using System.Collections;

public class Upgrades : Bullet {
	private float UpdradePrices = 100;
	public Texture2D Upgrade1,Upgrade2,Upgrade3,Upgrade4;
	public float UpgradeBulletDamage;
	public float UpgradeBulletSpeed;
	public bool UpgradeDamage = false;
	public bool UpgradeSpeed = false;

	void Awake(){
		UpgradeBulletDamage = BulletDamage;
		UpgradeBulletSpeed = Speed;
	}
	void Start () {		

	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnGUI(){

		if(GUI.Button(new Rect(15,15,Upgrade1.width,Upgrade1.height), Upgrade1)){
			UpgradeDamage = true;
			UpgradeBulletDamage += 5;


		}
		if(GUI.Button(new Rect(15,90,Upgrade2.width,Upgrade2.height), Upgrade2)){
			UpgradeSpeed = true;
			UpgradeBulletSpeed += 5;
			
		}
		if(GUI.Button(new Rect(15,165,Upgrade3.width,Upgrade3.height), Upgrade3)){}
		if(GUI.Button(new Rect(15,235,Upgrade4.width,Upgrade4.height), Upgrade4)){}
	}

}
