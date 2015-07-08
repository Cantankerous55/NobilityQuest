/*using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]
public class PlayerAnimationManager : MonoBehaviour 
{
	private Animator animator;
	private WillmotAttack2 willmotAttack;

	void Start () {
		animator = GetComponent<Animator> ();
		willmotAttack = GetComponent<WillmotAttack2> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		bool attackingThis = false;
		if (willmotAttack.attacking = true) {
			attackingThis = true;

			animator.SetBool ("Attack", attackingThis);
		}

	}
}
*/