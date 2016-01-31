using UnityEngine;
using System.Collections;

public class MusicButton : MonoBehaviour {

    public Sprite MusicOn;
    public Sprite MusicOff;
    bool isOn = true;

    void OnMouseUp()
    {
        if(isOn)
        {
            this.GetComponent<SpriteRenderer>().sprite = MusicOff;
        }
        else
        {
            
            this.GetComponent<SpriteRenderer>().sprite = MusicOn;
        }
        isOn = !isOn;
    }
}
