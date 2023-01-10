using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class MouseInput : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public UnityEvent upEvent;
    public UnityEvent downEvent;

    public void OnPointerDown(PointerEventData eventData)
    {
        downEvent?.Invoke();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        upEvent?.Invoke();
    }
}
