using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ActionHandler : MonoBehaviour {

	private Theme theme;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
	}

	public int evaluateSentence(List<GameObject> slots)
	{
		int correctTypeCount;
		foreach (GameObject slot in slots) {
			Word word = slot.GetComponent<Word> ();
		}
	}
}
