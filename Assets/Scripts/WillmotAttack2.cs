using UnityEngine;
using System.Collections;

[RequireComponent( typeof (Animator))]
public class WillmotAttack2 : MonoBehaviour 
{
	private Animator m_animator;
	private Animator m_droidDeath;
	private bool canKill;
	public Transform lineStart, lineEnd;
	private bool isAnimating;
	private Animation death;
	public Particle deathanim;
	private bool isDying;
	public float deathWaitTime;
	public GameObject DeathAnim;
	//bool hasStartedDeath = false;

	RaycastHit2D whatIHit;

	void Start()
	{
		m_animator = GetComponent<Animator> ();
		isDying = false;
		DeathAnim = GameObject.Find ("Death Anim") ;
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

		if (Input.GetKeyDown (KeyCode.Z)) {
			m_animator.Play ("WillmotAttack");
			if (canKill) {
				Destroy (whatIHit.collider.gameObject);
				//m_droidDeath = whatIHit.collider.gameObject.GetComponent<Animator> ();
				//m_droidDeath.Play ("droidDeath");
				//isDying = true;
				//m_droidDeath.SetBool ("isDying", isDying);

				//Instantiate ( DeathAnim, new Vector3 (whatIHit.collider.gameObject.transform.position.x, whatIHit.transform.position.y, whatIHit.transform.position.z), (whatIHit.collider.gameObject.transform.rotation));




				/*if (hasStartedDeath = false) 
				{
					//whatIHit.collider.gameObject.GetComponent<Animator>().SetTrigger("DeathAnimation");
					//StartCoroutine(DeathWait(whatIHit.collider.gameObject));
				}

			} else {
				if (canKill) {
					Destroy (whatIHit.collider.gameObject);
				}

			}
		}
	}
		IEnumerator DeathWait (GameObject objectToDestroy) 
		{
			hasStartedDeath = true;
			yield return new WaitForSeconds (1f);
			Destroy (objectToDestroy.gameObject);
			StopCoroutine ("DeathWait");
		}*/
}

		}

	}
}