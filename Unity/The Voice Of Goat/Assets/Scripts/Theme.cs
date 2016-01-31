using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Theme {

	[SerializeField]
	private GameObject image;
	private string name;

	private SortedList<Word.Type, int> types = new SortedList<Word.Type, int> ();
	private Dictionary<Word, int> words = new Dictionary<Word, int> ();

	public GameObject getImage()
	{
		return image;
	}

	public void setName(string name)
	{
		this.name = name;
	}

	public string getName()
	{
		return name;
	}

	public void addWord(Word word, int value)
	{
		words.Add (word, value);
	}

	public int getWordValue(Word word)
	{
		return words [word];
	}

	public void addType(Word.Type type, int value)
	{
		types.Add (type, value);
	}

	public SortedList<Word.Type, int> getTypes () {
		return types;
	}

}
