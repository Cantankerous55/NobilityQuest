using UnityEngine;
using System.Collections;

public class EnemyBullets : MonoBehaviour {

	public float fireRate; 		//rate at which bullets will fire
	public float speed;   	    //speed at which bullets will travel

	public GameObject player;	//Setting which Game Object will be treated as the player

	private Rigidbody2D myRigid;
	private float lifetime = 2.0f;


	// Use this for initialization
	void Start () {
	
		player = GameObject.Find ("Player") ;

		myRigid = GetComponent <Rigidbody2D> ();

		if (player.transform.position.x < this.transform.position.x)
		{
			speed = -speed;

		}

	}
	
	// Update is called once per frame
	void Update () {
		myRigid.velocity = new Vector2 (speed, myRigid.velocity.y);
		//Destroy (this.gameObject, lifetime);
	}
}
