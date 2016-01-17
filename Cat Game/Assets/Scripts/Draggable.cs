using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
	//these two functions are needed in order for OnDrag to work
	public void OnBeginDrag(PointerEventData eventData){
		//GetComponent<CanvasGroup> ().blocksRaycasts = false;
	}
	public void OnEndDrag(PointerEventData eventData){
		//GetComponent<CanvasGroup> ().blocksRaycasts = true;
	}


	public void OnDrag(PointerEventData eventData){
		this.transform.position = eventData.position;
	}


}
