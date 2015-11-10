using UnityEngine;
using System.Collections;

public class PlatformMovement : MonoBehaviour {
	public float scrollSpeed;

	// Update is called once per frame
	void Update () {
		transform.position -= new Vector3 (scrollSpeed * Time.deltaTime, 0.0f, 0.0f);
	}
}
