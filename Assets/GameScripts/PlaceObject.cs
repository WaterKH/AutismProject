using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlaceObject : MonoBehaviour {

	public bool hovering;
	public Color initialColor;
	public Color finalColor;
	public GameObject currObjectColor;
	public bool switchColor;

	void Awake()
	{
		initialColor = currObjectColor.GetComponent<RawImage>().color;
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		currObjectColor.GetComponent<RawImage>().color = finalColor;
	}

	void OnTriggerStay2D(Collider2D col)
	{
		if(!col.transform.GetComponent<DragScript>().isDragging)
			col.GetComponent<CanvasGroup>().alpha = Mathf.Lerp(col.GetComponent<CanvasGroup>().alpha, 0, Time.deltaTime);

		if(col.GetComponent<CanvasGroup>().alpha <= 0.05f)
		{
			col.gameObject.SetActive(false);
			currObjectColor.GetComponent<RawImage>().color = initialColor;
		}
	}

}
