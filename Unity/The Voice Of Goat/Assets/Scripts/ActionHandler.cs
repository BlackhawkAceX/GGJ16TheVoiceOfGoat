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

	public int evaluateSentence(List<PlaceholderLogic> placeholders)
	{
		int correctTypeCount = 0;
		foreach (PlaceholderLogic placeholder in placeholders) {
			Word word = placeholder.GetComponent<Word> ();
			if (placeholder.getType () == word.getType ())
				correctTypeCount++;
		}
		return correctTypeCount;
	}
}
