using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Furniture : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler{
	//public int CAPACITY = 3; // how many cats this furniture can contain.
	//GameObject[] slots;

	//these two functions are needed in order for OnDrop to work
	public void OnPointerEnter(PointerEventData eventData){
	}
	public void OnPointerExit(PointerEventData eventData){
	}

	void Start(){
		//slots = new GameObject[CAPACITY];
	}
	/*
	public void OnTriggerEnter(Collider cat){
		Debug.Log ("OnTriggerEnter");
		Color color = cat.gameObject.GetComponent<Renderer>().material.color;
		color.a -= 1.0f;
		//cat.gameObject.GetComponent<Renderer>().material.color.a = 0.0f;
		cat.gameObject.SetActive (false);
	}*/

	public void OnDrop( PointerEventData eventData){
		Debug.Log ("OnDrop");
		Draggable cat = eventData.pointerDrag.GetComponent<Draggable> ();
		cat.gameObject.SetActive (false);

	}

}
