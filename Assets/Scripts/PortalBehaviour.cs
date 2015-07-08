using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class PortalBehaviour : MonoBehaviour 
{
	public GameObject otherPortal;
	public float offset;

	private GameObject player;
	private Vector2 targetPosition;
	private Platformer2DUserControl playerMovement;

	void Start()
	{
		player = GameObject.Find ("Player");
		targetPosition = otherPortal.transform.position;
		playerMovement = player.GetComponent<Platformer2DUserControl>();
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.name == "Player" && playerMovement.CanTeleport)
		{
			player.transform.position = new Vector2(targetPosition.x + offset, targetPosition.y);
			playerMovement.CanTeleport = false;
		}
	}

	void OnTriggerExit2D (Collider2D other)
	{
		if (other.gameObject.name == "Player" && !playerMovement.CanTeleport)
		{
			playerMovement.CanTeleport = true;
		}
	}
}
