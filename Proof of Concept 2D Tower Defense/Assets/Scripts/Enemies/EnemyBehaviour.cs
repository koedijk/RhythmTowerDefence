using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour {
    [SerializeField]
	private float walkSpeed = 0f;
	[SerializeField]
    private int health = 0; //deze nog veranderen
	[SerializeField]
    private int fireRate = 1; // Deze moet nog veranderd worden als zowel toren als enemy kunnen schieten
    // Damage moet nog ingevoerd worden.

	// Update is called once per frame
	void Update () {
		transform.position -= new Vector3 (walkSpeed * Time.deltaTime, 0.0f, 0.0f);


		if (this.transform.position.x <= 6 /*Voor de toren, dit nummer is altijd hoger dan de X van de toren*/) 
		{				
			this.walkSpeed = 0f;
			//Elke enemy heeft zijn eigen attack scripts
	    }
		//Hier komt de attack animatie en de damage output.
	
	}
}
