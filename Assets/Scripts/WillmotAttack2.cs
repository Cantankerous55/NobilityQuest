using UnityEngine;
using System.Collections;

public class WillmotAttack2 : MonoBehaviour {

	public bool canAttack;
	public Transform lineStart, lineEnd;

	RaycastHit2D whatIHit;

	// Update is called once per frame
	void Update () {
		Raycasting ();
	}


	void Raycasting ()
	{
		Debug.DrawLine (lineStart.position, lineEnd.position, Color.red);

		if (Physics2D.Linecast (lineStart.position, lineEnd.position, 1 << LayerMask.NameToLayer("Enemy") ) ) 
		    {

			whatIHit = (Physics2D.Linecast (lineStart.position, lineEnd.position, 1 << LayerMask.NameToLayer("Enemy"))); 
			canAttack = true;
			Debug.Log ("I can attack.");

		}
		else 
		{
			canAttack = false;
			Debug.Log ("Can't Attack.");
		}
		if (Input.GetKeyDown(KeyCode.Z) && canAttack == true) {
			Destroy (whatIHit.collider.gameObject);
		}
	}
}
