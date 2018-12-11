using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public GameObject[] hazards;
	public int hazardCount;
	public Vector3 spawnValues;
	public float spawnWait;
	public float startWait;
	public float waiveWait;

	public GUIText scoreText;
	public GUIText restartText;
	public GUIText gameOverText;

	private bool gameOver;
	private bool restart;
	private int score;

	void Start() {
		gameOver = false;
		restart = false;
		restartText.text = "";
		gameOverText.text = "";

		score = 0;
		UpdateScore ();
		StartCoroutine (SpawnWaves ());
	}

	void Update() {
		if (restart) {
			if (Input.GetKeyDown(KeyCode.R)) {
				SceneManager.LoadScene ("Main");
			}
		}
	}

	IEnumerator SpawnWaves() {
		yield return new WaitForSeconds (startWait);
		while (true) {
			for (int i = 0; i < hazardCount; i++) {
				GameObject hazard = hazards [Random.Range (0, hazards.Length)];
				Vector3 spawnPosition = new Vector3 (
					Random.Range (-spawnValues.x, spawnValues.x), 
					spawnValues.y, 
					spawnValues.z
				);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (hazard, spawnPosition, spawnRotation);

				yield return new WaitForSeconds (spawnWait);

				if (gameOver) {
					restartText.text = "Press 'R' to restart";
					restart = true;
					break;
				}
			}

			yield return new WaitForSeconds (waiveWait);
		}
	}

	public void AddScore(int newScore) {
		score += newScore;
		UpdateScore ();
	}

	void UpdateScore() {
		scoreText.text = "Score: " + score.ToString();
	}

	public void GameOver() {
		gameOverText.text = "Game Over";
		gameOver = true;
	}
}
