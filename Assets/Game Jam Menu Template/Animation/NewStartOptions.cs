using UnityEngine;
using System.Collections;

public class NewStartOptions : MonoBehaviour {

	public Canvas uiCanvas;
	public AudioSource audioSource;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void startButton(){

		Application.LoadLevel ("Scene1");
		uiCanvas.enabled = false;
		audioSource.Pause ();

	}
}
