using UnityEngine;
using System.Collections;

public class SmallDroidBehaviour : MonoBehaviour 
{

	public float walkSpeed = 1.5f;
	public float wallLeft = 0.0f;
	public float wallRight = 5.0f;

	public GameObject leftWall;
	public GameObject rightWall;

	private Vector2 targetPosition;
	private Vector2 leftWallPosition;
	private Vector2 rightWallPosition;
	 
	void Start()
	{
		targetPosition = new Vector2 (rightWall.transform.position.x, rightWall.transform.position.y);
		leftWallPosition = new Vector2 (leftWall.transform.position.x, leftWall.transform.position.y);
		rightWallPosition = new Vector2 (rightWall.transform.position.x, rightWall.transform.position.y);
	}
		void Update () 
	{
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
