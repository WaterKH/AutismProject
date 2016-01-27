using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DragScript : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

	public GameObject objectMoving;
	public bool isDragging;
	private PointerEventData pointerData;
	public Vector2 finalPosition;

	#region IBeginDragHandler implementation

	public void OnBeginDrag (PointerEventData eventData)
	{
		objectMoving = eventData.pointerEnter;
		if(objectMoving.tag == "Moveable")
		{
			//objectMoving.transform.position = eventData.position;
			isDragging = true;
			pointerData = eventData;
		}
		else
		{
			objectMoving = null;
		}
	}

	#endregion

	#region IDragHandler implementation

	public void OnDrag (PointerEventData eventData)
	{
		//if(objectMoving.tag == "Moveable")
		//	objectMoving.transform.position = Vector2.Lerp(objectMoving.transform.position, eventData.position, 
		//												   Time.deltaTime * 2);
	}

	#endregion

	#region IEndDragHandler implementation

	public void OnEndDrag (PointerEventData eventData)
	{
 		//objectMoving = null;
 		isDragging = false;
 		pointerData = null;
 		finalPosition = eventData.position;
	}

	#endregion


	void Update()
	{
		if(isDragging)
		{
			objectMoving.transform.position = Vector2.Lerp(objectMoving.transform.position, pointerData.position,
														   Time.deltaTime * 10);
		}
		else if(objectMoving != null)
		{
			objectMoving.transform.position = Vector2.Lerp(objectMoving.transform.position, finalPosition, 
														   Time.deltaTime * 10);
		}
	}

}
