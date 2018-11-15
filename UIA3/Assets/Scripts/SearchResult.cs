using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchResult : MonoBehaviour {


	public Text Title;
	public Text Type;
	public Text Description;

	// Use this for initialization
	void Start () {
		
	}
	
	public bool Matches(string match)
	{
		return true;
	}
}
