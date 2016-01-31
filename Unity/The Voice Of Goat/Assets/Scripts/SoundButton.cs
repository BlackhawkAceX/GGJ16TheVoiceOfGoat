using UnityEngine;
using System.Collections;

public class SoundButton : MonoBehaviour {

    public Sprite SoundOn;
    public Sprite SoundOff;
    bool isOn = true;

    void OnMouseUp()
    {
        if (isOn)
        {
            this.GetComponent<SpriteRenderer>().sprite = SoundOff;
        }
        else
        {
            this.GetComponent<SpriteRenderer>().sprite = SoundOn;
        }
        isOn = !isOn;
    }
}
