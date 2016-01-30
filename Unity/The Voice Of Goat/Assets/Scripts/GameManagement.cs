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

    SpriteRenderer srPlaceholder1;
    SpriteRenderer srPlaceholder2;
    SpriteRenderer srPlaceholder3;

    void Start()
    {
        placeholder1 = placeholderObj1.GetComponent<PlaceholderLogic>();
        placeholder2 = placeholderObj2.GetComponent<PlaceholderLogic>();
        placeholder3 = placeholderObj3.GetComponent<PlaceholderLogic>();

        srPlaceholder1 = placeholderObj1.GetComponent<SpriteRenderer>();
        srPlaceholder2 = placeholderObj2.GetComponent<SpriteRenderer>();
        srPlaceholder3 = placeholderObj3.GetComponent<SpriteRenderer>();
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
        //Debug.Log(draggedObject.GetComponent<SpriteRenderer>);
        if (srPlaceholder1.bounds.Intersects(draggedObject.GetComponent<SpriteRenderer>().bounds))
        {
            Debug.Log("intersects with placeholder1");
        }
        if (srPlaceholder2.bounds.Intersects(draggedObject.GetComponent<SpriteRenderer>().bounds))
        {
            Debug.Log("intersects with placeholder2");
        }
        if (srPlaceholder3.bounds.Intersects(draggedObject.GetComponent<SpriteRenderer>().bounds))
        {
            Debug.Log("intersects with placeholder3");
        }
    }
}
