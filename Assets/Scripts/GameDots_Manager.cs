using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameDots_Manager : MonoBehaviour {

	public GameObject dot;
	public int numberOfSpots;
	public float yMax = 5.35f;
	public float yMin = -3.35f;
	public float xMax = 8.19f;
	public float xMin = -8.29f;
	public float zMax = 2.0f;
	public float zMin = -2.0f;
	public List<GameObject> myListOfDots = new List<GameObject> ();
	
	// Use this for initialization
	void Start () {
		numberOfSpots = 10;
		GenerateDots ();
	}
	
	// Update is called once per frame
	void Update () {

		//if New Dots button is hit...then call the generate dots method
	
	}

	public void GenerateDots(){
		for (int i = 0; i < numberOfSpots; i++) {
			GameObject dizzyDot = (GameObject)Instantiate(dot);;
			//dizzyDot.visible.enadbled = false;
			Vector3 dotPosition = new Vector3 (
				                      Random.Range (xMin, xMax),
				                      Random.Range (yMin, yMax),
									  Random.Range (zMin, zMax));

			dizzyDot.transform.localPosition = dotPosition;
			dizzyDot.renderer.material.color = getRandomColor ();
			myListOfDots.Add (dizzyDot);

		foreach (GameObject listDot in myListOfDots) {
				//listDot.visible.enabled = true;
		}

		}
		foreach (GameObject dippDot in myListOfDots){
			Debug.Log(dippDot);
		}
	}

	public Color32 getRandomColor () {
		return new Color32 ((byte)Random.Range (0, 255), (byte)Random.Range (0, 255), (byte)Random.Range (0, 255), 1);  
	}

	public void ClearOldListODots (){
		//myListOfDots.Clear ();

		foreach (GameObject listDot in myListOfDots) {
			//listDot.visible.enabled = true;
			Destroy (listDot);
		}


	}

}
