using UnityEngine;
using System.Collections;

public class TowerBehaviour : MonoBehaviour {


	private Vector2 Center; //Center waarvandaan de Radius wordt berekend
	public float Radius = 5; //Lengte van afstand waarbinnen de tower objecten ziet
	private int layermask; 
	
	void Start(){
		Center = new Vector2(0,0); //Midden van de toren, niet aanraken
		layermask = LayerMask.GetMask ("1", "2"); //Alle Layers die aangevallen kunnen worden staan hier
	}

	void Update () {
		RadiusCheck(); // Voert functie RadiusCheck iedere frame uit.
	}

	private void RadiusCheck(){
		Collider2D col = Physics2D.OverlapCircle(Center, Radius, /*layers*/ layermask); // Laat de toren kijken of er enemies in zijn bereik zijn en op welke layer ze zitten

		if (col){
			//Debug.Log(col); //Debug logged als een enemy in het bereik van deze toren is.
			//Shoot

		}
	}

	private void OnDrawGizmos(){ //Deze gizmo laat ons het bereik van onze torens zien, dit scheelt in testen.
		Gizmos.color = Color.white;
		Gizmos.DrawWireSphere(transform.position, Radius);
	}
	/*
	private void LineRenderPrep(){ // Linerenderer voor lasers (Nog niet af)
		LineRenderer.SetColors = Color.red;
		LineRenderer.isVisible = 0;

	}
	 */
}
