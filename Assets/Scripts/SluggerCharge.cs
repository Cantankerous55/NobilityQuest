using UnityEngine;
using System.Collections;

public class SluggerCharge : MonoBehaviour {

	public bool inRange;
	public Transform lineLeftStart, lineLeftEnd;
	public Transform lineRightStart, lineRightEnd; 
	public int movement = 1;
	public GameObject player;

	SmallDroidBehaviour smallDroidScript;

	public float walkSpeed = 1.5f;
	public float chargeSpeed = 3.0f;
	public float wallLeft = 0.0f;
	public float wallRight = 5.0f;
	public float movementSpeed = .05f;
	
	public GameObject leftWall;
	public GameObject rightWall;
	
	private Vector2 targetPosition;
	private Vector2 leftWallPosition;
	private Vector2 rightWallPosition;

	void Start ()
	{
		targetPosition = new Vector2 (rightWall.transform.position.x, rightWall.transform.position.y);
		leftWallPosition = new Vector2 (leftWall.transform.position.x, leftWall.transform.position.y);
		rightWallPosition = new Vector2 (rightWall.transform.position.x, rightWall.transform.position.y);

	}
	

	// Update is called once per frame
	void Update () 
	{
		MovementType ();
	}

	void MovementType()
	{

		if((Physics2D.Linecast (lineLeftStart.position, lineLeftEnd.position, 1 << LayerMask.NameToLayer("Player"))) || Physics2D.Linecast (lineRightStart.position, lineRightEnd.position, 1 << LayerMask.NameToLayer("Player")))
		{
			this.gameObject.transform.position = Vector2.MoveTowards (this.gameObject.transform.position, new Vector2(player.transform.position.x, 0), Time.deltaTime * chargeSpeed);
		}
		else
		{
			// TODO: Normal patrol movement. 
//			if (Vector2.Distance (gameObject.transform.position, targetPosition) < 0.05f)
//			{
//				if(targetPosition == leftWallPosition)
//				{
//					targetPosition = new Vector2 (rightWall.transform.position.x, rightWall.transform.position.y);
//				}
//				else if(targetPosition == rightWallPosition)
//				{
//					targetPosition = new Vector2 (leftWall.transform.position.x, leftWall.transform.position.y);
//				}
//			}
//			else
//			{
//				transform.position = Vector2.MoveTowards (gameObject.transform.position, targetPosition, walkSpeed * Time.deltaTime);
//			}

			if (gameObject.transform.position.x >= rightWallPosition.x || gameObject.transform.position.x <= leftWallPosition.x){
				//movementSpeed = -movementSpeed;
				this.gameObject.transform.Rotate (0,180,0);
			}
			gameObject.transform.Translate (movementSpeed, 0f, 0f);
		}
	}
}
	
