using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
	public float walkSpeed;

	// Update is called once per frame
	void Update () {
		transform.position -= new Vector3 (walkSpeed * Time.deltaTime, 0.0f, 0.0f);


	//	if (this.transform.position.x >= 0 /*Voor de toren*/) {				
	//  }

	}
}
