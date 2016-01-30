using UnityEngine;
using System.Collections;

public class MouseclickDetection : MonoBehaviour {
    public GameObject gameManager;
    GameManagement managementScript;

    void Start()
    {
        managementScript = gameManager.GetComponent<GameManagement>();
    }
    #if UNITY_STANDALONE_WIN
    void OnMouseDown()
    {
        managementScript.setDraggedObject(this.gameObject);
    }
    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objectPosition;
    }
    void OnMouseUp()
    {
        managementScript.clearDraggedObject();
    }
#endif
}
