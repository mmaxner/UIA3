using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayPauseToggler : MonoBehaviour, IPointerDownHandler { 

	public GameObject other;

	public void OnPointerDown(PointerEventData e)
	{
		other.SetActive(true);
		this.gameObject.SetActive(false);
	}
}
