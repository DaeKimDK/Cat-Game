using UnityEngine;
using System.Collections;

public class DragScript : MonoBehaviour {
	private Vector3 screenPoint;
	private Vector3 offset;

	void OnMouseDown(){
		Debug.Log ("test");
		screenPoint = Camera.main.WorldToScreenPoint (this.gameObject.transform.position);

		offset = this.gameObject.transform.position - Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
	}

	void OnMouseDrag(){
		Debug.Log ("test2");
		Vector3 cursorPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 cursorPosition = Camera.main.ScreenToWorldPoint (cursorPoint) + offset; 
		transform.position = cursorPosition;
	}
}
