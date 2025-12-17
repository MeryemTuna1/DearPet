using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class drag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    RectTransform transformR;
    Canvas canvas;
    Vector3 startPos;

    private void Awake()
    {
        transformR = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        startPos = transformR.anchoredPosition;
    }
    public void OnDrag(PointerEventData eventData)
    {
        transformR.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        if (eventData.pointerEnter == null || !eventData.pointerEnter.CompareTag("dropZone"))
        {
            transformR.anchoredPosition = startPos;
        }
    }
}
