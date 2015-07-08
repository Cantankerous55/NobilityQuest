using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;
using UnityEngine.UI;

public class Damage : MonoBehaviour {

	public int playerLives;
	public GameObject Enemy1;
	public GameObject Enemy2;
	public Vector2 respawnPosition;
	private bool canTakeDamage;



	// Use this for initialization
	void Start () {
	

		playerLives = 3;
		GameObject.Find ("Lives3").gameObject.SetActive (true);
		canTakeDamage = true;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

		void OnTriggerEnter2D (Collider2D other){

		if (other.gameObject.tag == "Enemy" && canTakeDamage == true)
		{
			playerLives = playerLives - 1;
			this.gameObject.transform.position = new Vector2 (respawnPosition.x, respawnPosition.y);
			canTakeDamage = false;

		if (new Vector2 (this.gameObject.transform.position.x, this.gameObject.transform.position.y) == new Vector2 (respawnPosition.x, respawnPosition.y));
				{
				canTakeDamage = true;
				}

	Debug.Log ("You have " + playerLives + " lives.");
		}

		if (other.gameObject == Enemy2 && canTakeDamage == true) 
		{
			playerLives = playerLives - 1;
			this.gameObject.transform.position = new Vector2 (respawnPosition.x, respawnPosition.y);
			Debug.Log ("You have " + playerLives);
		}

		//If Lives = 2, Set lives counter to 2
		if (playerLives == 2) 
		{
			GameObject.Find ("Lives3").gameObject.SetActive (false);
		}

		//If Lives = 1, Set lives counter to 1
		if (playerLives == 1) 
		{
			GameObject.Find ("Lives2").gameObject.SetActive(false);
		}

		if (playerLives == 0) 
		{
			GameObject.Find ("Lives1").gameObject.SetActive(false);
		}
	}

}
