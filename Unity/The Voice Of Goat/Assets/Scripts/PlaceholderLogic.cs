using UnityEngine;
using System.Collections;

public class PlaceholderLogic : MonoBehaviour {

    // Use this for initialization
    bool occupationStatus;
    Word.Type pType;
    Word word;

    void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {

	}
    public void setType(Word.Type type)
    {
        pType = type;
    }
	public void setOccupied(bool occupationStatus)
	{
		this.occupationStatus = occupationStatus;
	}
    public bool isOccupied()
    {
        return occupationStatus;
    }
    public void setWord(GameObject word)
    {
        this.word = word.GetComponent<Word>();
    }
    public void clearWord()
    {
        word = null;
    }
	public Word.Type getType()
	{
		return pType;
	}

	public Word getWord() {
		return word;
	}
}
