using UnityEngine;
using System.Collections;

public class SluggerCharge : MonoBehaviour {

	public bool inRange;
	public Transform lineLeftStart, lineLeftEnd;
	public Transform lineRightStart, lineRightEnd; 
	public int movement = 1;

	SmallDroidBehaviour smallDroidScript;

	RaycastHit2D detectedLeft;
	RaycastHit2D detectedRight;

	public float walkSpeed = 1.5f;
	public float wallLeft = 0.0f;
	public float wallRight = 5.0f;
	
	public GameObject leftWall;
	public GameObject rightWall;
	
	private Vector2 targetPosition;
	private Vector2 leftWallPosition;
	private Vector2 rightWallPosition;
	

	// Update is called once per frame
	void Update () {
	 MovementType ();
	}

	void MovementType()
	{

		switch (movement){

			case 1:
		{

			if (Physics2D.Linecast (lineLeftStart.position, lineLeftEnd.position, 1 << LayerMask.NameToLayer("Player") ) ) 
			{
				
				detectedLeft = (Physics2D.Linecast (lineLeftStart.position, lineLeftEnd.position, 1 << LayerMask.NameToLayer("Player"))); 
				Debug.Log ("I see Willmot on my left.");
					inRange = true;
			}
	 

			if (Physics2D.Linecast (lineLeftStart.position, lineLeftEnd.position, 1 << LayerMask.NameToLayer("Player") ) ) 
				    {
					
					detectedRight = (Physics2D.Linecast (lineRightStart.position, lineRightEnd.position, 1 << LayerMask.NameToLayer("Player"))); 
					Debug.Log ("I see Willmot on my right.");
					inRange = true;

					}
				break;
			//default:

			if(Vector2.Distance (gameObject.transform.position, targetPosition) < 0.05f)
			{
				if(targetPosition == leftWallPosition)
				{
					targetPosition = new Vector2 (rightWall.transform.position.x, rightWall.transform.position.y);
				}
				else if(targetPosition == rightWallPosition)
				{
					targetPosition = new Vector2 (leftWall.transform.position.x, leftWall.transform.position.y);
				}
			}
			else
			{
				transform.position = Vector2.MoveTowards (gameObject.transform.position, targetPosition, walkSpeed * Time.deltaTime);
			}
					

			

			}
	}
}
}