using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Theme {

	[SerializeField]
	private GameObject image;

	private List<Word> words;

	public void addWords(List<Word> words)
	{
		this.words = words;
	}

	public List<Word> getWords()
	{
		return words;
	}
	
	public GameObject getImage()
	{
		return image;
	}

}
