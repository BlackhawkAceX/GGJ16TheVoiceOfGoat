using UnityEngine;
using System.Collections;

public class GameManagement : MonoBehaviour {
    public GameObject placeholderObj1;
    public GameObject placeholderObj2;
    public GameObject placeholderObj3;

    GameObject draggedObject = null;

    PlaceholderLogic placeholder1;
    PlaceholderLogic placeholder2;
    PlaceholderLogic placeholder3;

    BoxCollider2D srPlaceholder1;
    BoxCollider2D srPlaceholder2;
    BoxCollider2D srPlaceholder3;

    void Start()
    {
        placeholder1 = placeholderObj1.GetComponent<PlaceholderLogic>();
        placeholder2 = placeholderObj2.GetComponent<PlaceholderLogic>();
        placeholder3 = placeholderObj3.GetComponent<PlaceholderLogic>();

        srPlaceholder1 = placeholderObj1.GetComponent<BoxCollider2D>();
        srPlaceholder2 = placeholderObj2.GetComponent<BoxCollider2D>();
        srPlaceholder3 = placeholderObj3.GetComponent<BoxCollider2D>();
    }

    public void setDraggedObject(GameObject obj)
    {
        draggedObject = obj;
    }
    public void clearDraggedObject()
    {
        compareDistanceToPlaceholders(draggedObject);
        placeholder1.clearWord();
        placeholder2.clearWord();
        placeholder3.clearWord();
        draggedObject = null;
    }
    public void compareDistanceToPlaceholders(GameObject draggedObject)
    {
        if (srPlaceholder1.bounds.Intersects(draggedObject.GetComponent<BoxCollider2D>().bounds))
        {
            Debug.Log("intersects with placeholder1");
            draggedObject.transform.position = placeholderObj1.transform.position;
        }
        if (srPlaceholder2.bounds.Intersects(draggedObject.GetComponent<BoxCollider2D>().bounds))
        {
            Debug.Log("intersects with placeholder2");
            draggedObject.transform.position = placeholderObj2.transform.position;
        }
        if (srPlaceholder3.bounds.Intersects(draggedObject.GetComponent<BoxCollider2D>().bounds))
        {
            Debug.Log("intersects with placeholder3");
            draggedObject.transform.position = placeholderObj3.transform.position;
        }
    }
}
