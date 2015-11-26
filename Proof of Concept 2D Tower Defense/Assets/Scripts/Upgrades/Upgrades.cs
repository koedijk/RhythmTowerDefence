using UnityEngine;
using System.Collections;

public class Upgrades : StatsOfObjects {
	private float UpdradePrices = 100;
	public Texture2D Upgrade1,Upgrade2,Upgrade3,Upgrade4;

	//private GUIStyle testStyle = new GUIStyle();

	void Awake(){

	}
	void Start () {		

	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnGUI(){
		Color c = GUI.backgroundColor;
		GUI.backgroundColor = Color.clear;
		if(GUI.Button(new Rect(400,250,Upgrade1.width,Upgrade1.height), Upgrade1)){
			BulletDamage = +5;


		}
		GUI.backgroundColor = c;
		if(GUI.Button(new Rect(210,250,Upgrade2.width,Upgrade2.height), Upgrade2)){
			BulletSpeed = +5;
			
		}
		if(GUI.Button(new Rect(400,410,Upgrade3.width,Upgrade3.height), Upgrade3)){}
		if(GUI.Button(new Rect(210,410,Upgrade4.width,Upgrade4.height), Upgrade4)){}
	}

}
