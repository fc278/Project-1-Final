using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	int bronzePlayer;
	int silverPlayer;
	int goldPlayer;
	int miningSpeed;
	int timeToMine;
	float xPosition;

	public static int score;

	public GameObject cubePrefab;

	Vector3 cubePosition;
	GameObject currentCube;

	// Use this for initialization
	void Start () {
		goldPlayer = 0;
		bronzePlayer = 0;
		silverPlayer = 0;
		miningSpeed = 2;
		timeToMine = 3;

	}

	// Update is called once per frame
	void Update () {

		if (Time.time > timeToMine) {

			if (bronzePlayer == 2 && silverPlayer == 2 && goldPlayer < 1) {
				goldPlayer += 1;

				cubePosition = new Vector3 (Random.Range(-5, 5), Random.Range(-5, 5),0);
				currentCube = Instantiate (cubePrefab, cubePosition, Quaternion.identity);
				xPosition += 2;

				currentCube.GetComponent<Renderer> ().material.color = Color.yellow;
				currentCube.GetComponent<CubeBehavior> ().cubeType = "gold";
			}

			else if (bronzePlayer < 2) {
				bronzePlayer += 1;

				cubePosition = new Vector3 (Random.Range(-5, 5), Random.Range(-5, 5),0);
				currentCube = Instantiate (cubePrefab, cubePosition, Quaternion.identity);
				xPosition += 2;

				currentCube.GetComponent<Renderer> ().material.color = Color.red;
				currentCube.GetComponent<CubeBehavior> ().cubeType = "bronze";
			}

			else if (bronzePlayer >= 2) {
				silverPlayer += 1;

				cubePosition = new Vector3 (Random.Range(-5, 5), Random.Range(-5, 5),0);
				currentCube = Instantiate (cubePrefab, cubePosition, Quaternion.identity);
				xPosition += 2;

				currentCube.GetComponent<Renderer> ().material.color = Color.white;
				currentCube.GetComponent<CubeBehavior> ().cubeType = "silver";
			}

			print("Bronze: " + bronzePlayer + " Silver: " + silverPlayer + " Gold: " + goldPlayer + " Score: " + score);
			timeToMine += miningSpeed;

		}

	}
}

// I was not sure how to allow the player to click on cubes, but I resolved and figured it out by asking the TA's for help.

