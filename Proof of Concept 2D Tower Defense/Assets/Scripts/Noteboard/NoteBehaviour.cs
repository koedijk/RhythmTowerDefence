using UnityEngine;
using System.Collections;

public class NoteBehaviour : MonoBehaviour {
	public float scrollSpeed;

	// Update is called once per frame
	void Update () {

		//Beweging aan de hand van "scrollSpeed"
		transform.position -= new Vector3 (scrollSpeed * Time.deltaTime, 0.0f, 0.0f);

		//Als dit object buiten het scherm is wordt deze verwijderd
		if (this.transform.position.x <= -3) {
		 Destroy(this.gameObject);
		}
	}
}
