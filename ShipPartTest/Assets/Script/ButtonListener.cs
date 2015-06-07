using UnityEngine;
using System.Collections;

public class ButtonListener : MonoBehaviour {

	private Main main;
	public bool isShow;

	// Use this for initialization
	void Start () {
		main = GameObject.Find("Main").GetComponent<Main>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseUp(){

		main.startTest ();
	}

}
