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
    }
}
