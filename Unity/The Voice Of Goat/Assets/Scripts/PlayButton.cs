using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour {

	void OnMouseUp()
    {
        SceneManager.LoadScene("Game");
    }
}
