using UnityEngine;
using System.Collections;

public class ShootAtPlayer : MonoBehaviour {


	public float playerRange;

	public float waitBetweenShots;
	private float shotCounter;

	public GameObject enemyBullet;

	public GameObject player;

	public Transform shootPoint;

	// Use this for initialization
	void Start () {

		player = GameObject.Find ("Player");

		shotCounter = waitBetweenShots;
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.DrawLine (new Vector3 (transform.position.x - playerRange, transform.position.y, transform.position.z) , new Vector3 (transform.position.x + playerRange, transform.position.y, transform.position.z)) ;
	
		shotCounter -= Time.deltaTime;

		if (player.transform.position.x > this.transform.position.x && player.transform.position.x < this.transform.position.x + playerRange && shotCounter < 0) {

			Instantiate (enemyBullet, shootPoint.position, shootPoint.rotation);
			shotCounter = waitBetweenShots;
		}
			
		if (player.transform.position.x < this.transform.position.x && player.transform.position.x > this.transform.position.x - playerRange && shotCounter < 0) {
			
			Instantiate (enemyBullet, shootPoint.position, shootPoint.rotation);
			shotCounter = waitBetweenShots;

		}
	
	}
}
