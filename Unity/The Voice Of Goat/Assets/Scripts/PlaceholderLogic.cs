using UnityEngine;
using System.Collections;

public class PlaceholderLogic : MonoBehaviour {

    // Use this for initialization
    bool occupationStatus;
    Word.Type pType;

    void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {

	}
    public void setType(Word.Type type)
    {
        pType = type;
    }
    public bool isOccupied()
    {
        return occupationStatus;
    }
}
