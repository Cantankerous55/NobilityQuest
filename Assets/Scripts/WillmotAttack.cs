using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class WillmotAttack : MonoBehaviour {

	private Vector2 origin;
	private float direction;
	public float hitDist;
	public float heightDist;
	public GameObject Enemy_1;
	public LayerMask mask;
	private float previousGood;


	// Use this for initialization
	void Start () {
		}
	
	// Update is called once per frame
	void Update () {
			 
		//origin = (player.transform.position.x, player.transform.position.y);
		//direction = 

		direction = Input.GetAxis ("Horizontal");
		if (direction > 0) 
		{
			direction = 1f;

			previousGood = 1f;
		}

		if (direction < 0)
		{
			direction = -1f;

			previousGood = -1f;
		}

		if (direction == 0) 
		{
			direction = previousGood;
		}

		//Ray2D hitRay = new Ray2D (new Vector2(transform.position.x, transform.position.y) , new Vector2 (direction, 0));


		if (Input.GetKeyDown (KeyCode.Z)) {

			Debug.Log ("Z working.");

			RaycastHit2D hit = Physics2D.Raycast( new Vector2 (this.transform.position.x, this.transform.position.y - heightDist), new Vector2 (direction,0),  hitDist, 8);

				Debug.DrawRay (new Vector2 (this.transform.position.x, this.transform.position.y - heightDist) , new Vector2 (direction,0) * 100f , Color.red, 100f, false);

			if(hit.collider != null)
			{
				Debug.Log ( hit.collider.name );
			if (hit.collider.gameObject == Enemy_1)
			{
				
				Destroy(Enemy_1);
				
			}
			}
		}
	}
}