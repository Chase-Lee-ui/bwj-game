using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Mouse_Move : MonoBehaviour
{
    public Canvas Canva;
    public void DragHandler(BaseEventData data)
    {
        PointerEventData pointerData = (PointerEventData)data;

        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            (RectTransform)Canva.transform,
            pointerData.position,
            Canva.worldCamera,
            out position
        );

        transform.position = Canva.transform.TransformPoint(position);
        this.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
    }

    void Update()
    {
        if(Canva == null)
        {
            Canva = GameObject.Find("Canvas_Interact").GetComponent<Canvas>();
        }
        if(Input.GetKeyUp(KeyCode.Mouse0))
        {
            this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
        }
    }
}
