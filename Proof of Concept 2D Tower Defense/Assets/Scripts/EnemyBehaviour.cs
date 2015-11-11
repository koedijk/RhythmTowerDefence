using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour {
	[SerializeField]
	private float walkSpeed;

	// Update is called once per frame
	void Update () {
		transform.position -= new Vector3 (walkSpeed * Time.deltaTime, 0.0f, 0.0f);


		if (this.transform.position.x <= 6 /*Voor de toren, dit nummer is altijd hoger dan de X van de toren*/) 
		{				
			this.walkSpeed = 0f;
			//Attackmode();
	    }
		//Hier komt de attack animatie en de damage output.
	
	}
}
