using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {

	public GameObject[] obj;
	public float BPM = 180;
	public float BPM2 = 160;

	public float BPS1 = BPM / 60; // 180 / 60 = 3 in dit geval, Er worden dus 3 monsters per seconde gespawnd
	public float BPS2 = BPM2 / 60; // 160/ 60 = 2.666 in dit geval, Er worden dus 2.66 monsters per seconde gespawnd


	// Use this for initialization
	void Start () {
		Spawn (); //Voert functie Spawn uit
	}
	
	void Spawn()
	{
		Instantiate(obj[Random.Range (0, obj.GetLength(0))], transform.position, Quaternion.identity); //Spawnt 1 van de objecten in de array "obj"
		Invoke ("Spawn", Random.Range (spawnMin, spawnMax)); //Voert deze functie opnieuw uit met de gegeven parameters, in dit geval blijven die altijd hetzelfde.

	}
}
