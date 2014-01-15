using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GuiScript : MonoBehaviour {


	//public GUIText new_dots;
	GameDots_Manager gameDotManager;
	public Vector2 MousePosition;


	// Use this for initialization
	void Start () {

		gameDotManager = GameObject.Find ("Game_Dots_Manager").GetComponent<GameDots_Manager> ();
		//new_dots.enabled = true;
	}

	// Update is called once per frame
	void Update () {
	
		int fingerCount = 0;
		MousePosition = Input.mousePosition;
		foreach (Touch touch in Input.touches) {
			if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled && guiTexture.HitTest (touch.position)) {
				fingerCount++;
			}
		}
		if (fingerCount > 0) {
			gameDotManager.GenerateDots();
			//Debug.Log ("Should have created a bunch of dots");
			fingerCount = 0;
		}
		if (Input.GetMouseButtonDown (0)) {
			gameDotManager.ClearOldListODots ();
			gameDotManager.GenerateDots();
		}
	}
}
