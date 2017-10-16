using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehavior : MonoBehaviour {
	public string cubeType;


	void OnMouseDown() {
		if (cubeType == "bronze") {
			GameController.score += 1;
		} 

		else if (cubeType == "silver") {
			GameController.score += 10;
		} 

		else if (cubeType == "gold") {
			GameController.score += 100;
		}

		GameController.score++;
		Destroy (gameObject);
//		print (GameController.score);
	}
}
