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
        Debug.Log("got it");
        draggedObject = obj;
    }
    public void clearDraggedObject()
    {
        draggedObject = null;
        Debug.Log("cleared");
    }
    public void compareDistanceToPlaceholders()
    {
        if (srPlaceholder1.bounds.Intersects(draggedObject.GetComponent<SpriteRenderer>().bounds))
        {

        }
        if (srPlaceholder2.bounds.Intersects(draggedObject.GetComponent<SpriteRenderer>().bounds))
        {

        }
        if (srPlaceholder3.bounds.Intersects(draggedObject.GetComponent<SpriteRenderer>().bounds))
        {

        }
    }
}
