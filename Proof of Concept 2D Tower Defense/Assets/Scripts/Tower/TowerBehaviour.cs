using UnityEngine;
using System.Collections;

public class TowerBehaviour : MonoBehaviour {
	[SerializeField]
	private Transform sightStart, sightGunPoint,sightEnd;
	private Vector2 Center; //Center waarvandaan de Radius wordt berekend
	public float Radius = 5; //Lengte van afstand waarbinnen de tower objecten ziet
	private int layermask;
    private bool Shooting = false;
    private bool spotted = false;
    private int health = 0; //Deze nog veranderen(moet ook nog een healthbar komen)
    //Damage voor de base tower(upgrade parts krijgen hun eigen??)

    void Awake(){

	}
	void Start(){
		Center = new Vector2(0,0); //Midden van de toren, niet aanraken
		layermask = LayerMask.GetMask ("1", "2"); //Alle Layers die aangevallen kunnen worden staan hier
	}

	void Update () {
		//Raycasting();
		RadiusCheck(); // Voert functie RadiusCheck iedere frame uit.
	}

	private void RadiusCheck(){
		Collider2D col = Physics2D.OverlapCircle(Center, Radius, /*layers*/ layermask); // Laat de toren kijken of er enemies in zijn bereik zijn en op welke layer ze zitten

		if (col){
			if(Shooting == false)
			{
				RaycastHit2D hit = Physics2D.Raycast(sightStart.position,sightEnd.position,10,layermask);// Kijken of er iets de witte lijn raakt
				Debug.DrawRay(sightStart.position,sightEnd.position); // De witte Lijn wanneer er collision is met col
				if(hit.collider)
				{
					Transform EnemyDetect = hit.collider.transform; // Positie van de enemy die in de Radius van de toren zit.
					Debug.DrawRay(sightGunPoint.position,EnemyDetect.position,Color.cyan); // Lijn van de zogenaamde GunPoint.
				}

			}

		}
	}

	private void OnDrawGizmos(){ //Deze gizmo laat ons het bereik van onze torens zien, dit scheelt in testen.
		Gizmos.color = Color.white;
		Gizmos.DrawWireSphere(transform.position, Radius);
	}
	void Raycasting()
	{
		Debug.DrawRay(sightStart.position,sightEnd.position,Color.blue);
		if(Shooting == false)
		{
				
				RaycastHit2D hit = Physics2D.Raycast(sightStart.position,sightEnd.position,100,layermask);
				//Transform EnemyDetect = hit.collider.transform;
				//Debug.DrawRay(sightStart.position,EnemyDetect.position,Color.cyan);
				if(hit.collider)
				{
					
					
					Shooting = true;
				}
				else{
					Shooting = false;
				}
				
		}


	}

}

