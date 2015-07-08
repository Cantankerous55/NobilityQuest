using UnityEngine;
using System.Collections;

public class WillmotAttack2 : MonoBehaviour 
{
	private Animator m_animator;
	private bool canKill;
	public Transform lineStart, lineEnd;

	RaycastHit2D whatIHit;

	void Start()
	{
		m_animator = GetComponent<Animator> ();
	}

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
			canKill = true;
			Debug.Log ("I can Kill " + whatIHit.transform.name);
		}
		else 
		{
			canKill = false;
			Debug.Log ("Can't kill anything.");
		}

		if (Input.GetKeyDown (KeyCode.Z))
	    {
			m_animator.Play ("WillmotAttack");
			if(canKill)
			{
				Destroy (whatIHit.collider.gameObject);
			}
		}
	}
}
