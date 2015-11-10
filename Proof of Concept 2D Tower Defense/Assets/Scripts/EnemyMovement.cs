using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
	public float scrollSpeed;

	// Update is called once per frame
	void Update () {
		transform.position -= new Vector3 (scrollSpeed * Time.deltaTime, 0.0f, 0.0f);


	//	if (this.transform.position.x >= 0 /*Voor de toren*/) {				
	//  }

	}
}
