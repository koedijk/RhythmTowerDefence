using UnityEngine;
using System.Collections;

public class MainSpawner : MonoBehaviour {

	private GameObject Spawner1;
	private GameObject Spawner2;
	private GameObject Spawner3;



	// Use this for initialization
	void Start () {
		Spawner1 = GameObject.Find ("EnemySpawner1");
		Spawner2 = GameObject.Find ("EnemySpawner2");
		Spawner3 = GameObject.Find ("EnemySpawner3");
	}
	
	// Update is called once per frame
	void Update () {

	}
}
