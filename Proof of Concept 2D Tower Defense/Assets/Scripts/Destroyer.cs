using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D other)
	{

		if (other.gameObject.transform.parent) {
			//Destroy (other.gameObject.transform.parent.gameObject);
			Debug.Log("Nummer 1");
		} 
		else 
		{
			//Destroy(other.gameObject);
			Debug.Log("Nummer 2");
		}
	}
}
