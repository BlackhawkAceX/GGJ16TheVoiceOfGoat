using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Word : MonoBehaviour{

	public enum Type {
		VERB,
		OBJECT,
		ADJECTIVE,
	}

	private string text;
	private Type type;
	private IDictionary<Word, int> associatedWords;

	public Word(string text, Type type) {
		this.text = text;
		this.type = type;
	}

	public Word(string text, Type type, IDictionary<Word, int> associatedWords) {
		new Word (text, type);
		this.associatedWords = associatedWords;
	}

	public string getText()
	{
		return text;	
	}

	public Type getType()
	{
		return type;
	}

	public int getAssociatedWordValue(Word word)
	{
		return associatedWords [word];
	}

}
