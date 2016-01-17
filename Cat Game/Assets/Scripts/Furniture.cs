using UnityEngine;
using System.Collections;

public class Furniture : MonoBehaviour{ //IDropHandler, IPointerEnterHandler, IPointerExitHandler{
	public GameObject manager;

	void OnTriggerEnter2D(Collider2D cat){
		Debug.Log ("OnTriggerEnter");
		//Color color = cat.gameObject.GetComponent<Renderer>().material.color;
		//color.a -= 1.0f;
		//cat.gameObject.GetComponent<Renderer>().material.color.a = 0.0f;
		//if(cat.gameObject.tag == "Cat"){

		cat.gameObject.SetActive (false);
	}
		
	/*
	public void OnDrop( PointerEventData eventData){
		Debug.Log ("OnDrop");
		Draggable cat = eventData.pointerDrag.GetComponent<Draggable> ();
		cat.gameObject.SetActive (false);

	}*/

}
