using UnityEngine;
using System.Collections.Generic;

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

	ActionHandler actionHandler;
	List<PlaceholderLogic> placeholders;

	int count;

    void Start()
    {
        placeholder1 = placeholderObj1.GetComponent<PlaceholderLogic>();
        placeholder2 = placeholderObj2.GetComponent<PlaceholderLogic>();
        placeholder3 = placeholderObj3.GetComponent<PlaceholderLogic>();

		placeholders = new List<PlaceholderLogic> ();
		placeholders.Add (placeholder1);
		placeholders.Add (placeholder2);
		placeholders.Add (placeholder3);

        srPlaceholder1 = placeholderObj1.GetComponent<BoxCollider2D>();
        srPlaceholder2 = placeholderObj2.GetComponent<BoxCollider2D>();
        srPlaceholder3 = placeholderObj3.GetComponent<BoxCollider2D>();

		actionHandler = new ActionHandler ();

		count = 0;
    }

    public void setDraggedObject(GameObject obj)
    {
        draggedObject = obj;
		GameObject placeholder = draggedObject.transform.parent.gameObject;
		if (placeholder != null) {
			PlaceholderLogic placeholderLogic = placeholder.GetComponent<PlaceholderLogic> ();
			placeholderLogic.setOccupied (false);
			draggedObject.transform.parent = null;
			count--;
		}
    }
    public void clearDraggedObject()
    {
		PlaceholderLogic placeholderLogic = compareDistanceToPlaceholders(draggedObject);
		if (placeholderLogic != null) {
			placeholderLogic.setOccupied (true);
			count++;
		}
		if (count == 3)
			actionHandler.evaluateSentence (placeholders);

		draggedObject = null;
	}
	public PlaceholderLogic compareDistanceToPlaceholders(GameObject draggedObject)
    {
		if (srPlaceholder1.bounds.Intersects(draggedObject.GetComponent<BoxCollider2D>().bounds))
        {
			if (!placeholder1.isOccupied ()) {
				Debug.Log("intersects with placeholder1");
				draggedObject.transform.position = placeholderObj1.transform.position;
				draggedObject.transform.parent = placeholder1.transform;
				return placeholder1;
			}
        }
        if (srPlaceholder2.bounds.Intersects(draggedObject.GetComponent<BoxCollider2D>().bounds))
        {
			if (!placeholder2.isOccupied ()) {
				Debug.Log ("intersects with placeholder2");
				draggedObject.transform.position = placeholderObj2.transform.position;
				draggedObject.transform.parent = placeholder2.transform;
				return placeholder1;
			}
		}
        if (srPlaceholder3.bounds.Intersects(draggedObject.GetComponent<BoxCollider2D>().bounds))
        {
			if (!placeholder3.isOccupied ()) {
				Debug.Log ("intersects with placeholder3");
				draggedObject.transform.position = placeholderObj3.transform.position;
				draggedObject.transform.parent = placeholder3.transform;
				return placeholder1;
			}
		}
		return null;
    }
}
