using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TowerHealth : MonoBehaviour
{

	private int maxHealth = 1000;
	private int minHealth = 1;
	private float towerCurHealth = 100;
	private float healthBarLenght;

	public float Health
	{
		get
		{
			return towerCurHealth;
		}
		set
		{
			towerCurHealth = value;
		}
	}

	TowerBehaviour TowerBase;

	void Start(){
		healthBarLenght = Screen.width /2;
	}
	void FixedUpdate(){
		AdjustcurHealth(0);
	}
	void OnGUI () {
		
		GUI.Box(new Rect(75,50, healthBarLenght, 20),towerCurHealth + "/" + maxHealth);
		
	} 
	public void AdjustcurHealth (int adj) {
		
		towerCurHealth += adj;
		
		if(towerCurHealth < 0)
			towerCurHealth = 0;
		
		if(towerCurHealth > maxHealth)
			towerCurHealth = maxHealth;
		
		if(maxHealth < 100)
			maxHealth = 100;
		if(towerCurHealth < minHealth)
			Destroy(this.gameObject);
			Destroy(TowerBase);
		
		healthBarLenght = (Screen.width / 2) * (towerCurHealth / (float)maxHealth);
		
	} 

	     
}
