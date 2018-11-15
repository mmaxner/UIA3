using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchList : MonoBehaviour {

	public float StartLocation = 900.0f;
	public float Increments = -200.0f;
	public RectTransform artistlabel;
	public RectTransform userslabel;
	public RectTransform acdc;
	public RectTransform helloween;
	public RectTransform dreamtheater;
	public RectTransform deadhead;
	public RectTransform luvr;
	public RectTransform george;
	public InputField search;


	public void Search()
	{
		float nextplace = 0;
		string searcher = search.text;
		artistlabel.gameObject.SetActive(true);
		artistlabel.localPosition = new Vector3(0, nextplace);
		nextplace -= 100;
		if ("AC/DC".StartsWith(searcher))
		{
			acdc.gameObject.SetActive(true);
			acdc.localPosition = new Vector3(0, nextplace);
			nextplace -= 200;
		}
		else
		{
			acdc.gameObject.SetActive(false);
		}

		if ("Helloween".StartsWith(searcher))
		{
			helloween.gameObject.SetActive(true);
			helloween.localPosition = new Vector3(0, nextplace);
			nextplace -= 200;
		}
		else
		{
			helloween.gameObject.SetActive(false);
		}

		if ("Dream Theater".StartsWith(searcher))
		{
			dreamtheater.gameObject.SetActive(true);
			dreamtheater.localPosition = new Vector3(0, nextplace);
			nextplace -= 200;
		}
		else
		{
			dreamtheater.gameObject.SetActive(false);
		}
		userslabel.gameObject.SetActive(true);
		userslabel.localPosition = new Vector3(0, nextplace);
		nextplace -= 100;

		if ("DeadHead62".StartsWith(searcher))
		{
			deadhead.gameObject.SetActive(true);
			deadhead.localPosition = new Vector3(0, nextplace);
			nextplace -= 200;
		}
		else
		{
			deadhead.gameObject.SetActive(false);
		}

		if ("muzakluvr".StartsWith(searcher))
		{
			luvr.gameObject.SetActive(true);
			luvr.localPosition = new Vector3(0, nextplace);
			nextplace -= 200;
		}
		else
		{
			luvr.gameObject.SetActive(false);
		}

		if ("George_Costanza".StartsWith(searcher))
		{
			george.gameObject.SetActive(true);
			george.localPosition = new Vector3(0, nextplace);
			nextplace -= 200;
		}
		else
		{
			george.gameObject.SetActive(false);
		}
	}
}
