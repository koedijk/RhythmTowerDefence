using UnityEngine;
using System.Collections;

public class StatsOfObjects : MonoBehaviour {

	Upgrade upgrade;
	Bullet bullet;
	
	private float bulletDamage = 10;
	public float BulletDamage{get{return bulletDamage;}set{bulletDamage = value;}}

	private float bulletSpeed = 15;
	public float BulletSpeed{get{return bulletSpeed;}set{bulletSpeed = value;}}
	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(bulletSpeed);
	}
}
