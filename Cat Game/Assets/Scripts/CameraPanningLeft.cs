using UnityEngine;
using System.Collections;

public class CameraPanningLeft : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetMouseButtonDown (0)) 
		{
			Camera.main.transform.Translate (-1,0,0);
		}

	}



}
