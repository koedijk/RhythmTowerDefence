using UnityEngine;
using System.Collections;

public class TowerTarget : MonoBehaviour {


	private Vector2 Center;
	private float Radius = 3;
	private int layermask;
	
	void Start(){
		Center = new Vector2(0,0); //Midden van de toren, niet aanraken
		layermask = LayerMask.GetMask ("1"); //Alle Layers die aangevallen worden, staan hier
	}

	void Update () {
		RadiusCheck(); // Voert functie RadiusCheck iedere frame uit.
	}

	private void RadiusCheck(){
		Collider2D col = Physics2D.OverlapCircle(Center, Radius, /*layers*/ layermask); // Laat de toren kijken of er enemies in zijn bereik zijn en op welke layer ze zitten

		if (col){
			Debug.Log(col); //Debug logged als een enemy in het bereik van deze toren is.
			//Shoot

		}
	}

	private void OnDrawGizmos(){ //Deze gizmo laat ons het bereik van onze torens zien, dit scheelt in testen.
		Gizmos.color = Color.white;
		Gizmos.DrawWireSphere(transform.position, Radius);
	}

	private void LineRenderPrep(){ // Linerenderer voor lasers (Nog niet af)
		LineRenderer.SetColors = Color.red;
		LineRenderer.isVisible = 0;

	}
}
