using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Wire : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public bool IsLeftWire;
    public Color CustomColor;
    private Image _image;
    private LineRenderer _lineRenderer;
    private Canvas _canvas;
    private bool _isDragStarted = false;
    private WireTask _wireTask;
    public bool IsSuccess = false;

        private void Awake()
    {
        _image = GetComponent<Image>();
        _lineRenderer = GetComponent<LineRenderer>();
        _canvas = GetComponentInParent<Canvas>();
        _wireTask = GetComponentInParent<WireTask>();
    }

    private void Update()
    {
        if (_isDragStarted)
        {
            Vector2 movePos;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(
                _canvas.transform as RectTransform,
                Input.mousePosition,
                _canvas.worldCamera,
                out movePos);

            _lineRenderer.SetPosition(0, transform.position);
            _lineRenderer.SetPosition(1, _canvas.transform.TransformPoint(movePos));
        }
        else
        {
            if(!IsSuccess)
            {
                _lineRenderer.SetPosition(0, Vector3.zero);
                _lineRenderer.SetPosition(1, Vector3.zero);
            }
        }

        bool isHovered = RectTransformUtility.RectangleContainsScreenPoint(transform as RectTransform, Input.mousePosition, _canvas.worldCamera);

        if (isHovered) //Entire If statement was commented out before
        {
            _wireTask.CurrentHoveredWire = this;
        }
    }

    public void SetColor(Color color)
    {
        _image.color = color;
        _lineRenderer.startColor = color;
        _lineRenderer.endColor = color;
    }

    public void OnDrag(PointerEventData eventData)
    {

    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (!IsLeftWire)
        {
            return;
        }
        if (IsSuccess)
        {
            return;
        }
        _isDragStarted = true;
        _wireTask.CurrentDraggedWire = this; //Commented out before
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (_wireTask.CurrentHoveredWire != null) //Entire if statement block commented out before
        {
            if (_wireTask.CurrentHoveredWire.CustomColor == CustomColor && !_wireTask.CurrentHoveredWire.IsLeftWire) 
            {
                IsSuccess = true;
                _wireTask.CurrentHoveredWire.IsSuccess = true;
            }
        }

        _isDragStarted = false;
        _wireTask.CurrentDraggedWire = null; //Commented out before
    }
}
