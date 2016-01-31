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
		int correctWordCount = 0;
		foreach (PlaceholderLogic placeholder in placeholders) {
			Word word = placeholder.getWord ();
			if (placeholder.getType () == word.getType ())
				correctTypeCount++;
			if (theme.getWordValue(word) != 0)
				correctTypeCount++;
		}
		return correctTypeCount + correctWordCount;
	}
}
