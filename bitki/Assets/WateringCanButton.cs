using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WateringCanButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    public Camera cam;
    public GameObject wateringCan;
    public void OnDrag(PointerEventData eventData)
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Ray ray = cam.ScreenPointToRay(eventData.position);

        if(Physics.Raycast(ray, out var hitInfo))
        {
            if(hitInfo.collider.gameObject == wateringCan)
            {
                //water level gösterilsin, game açılması sorulsun
            }
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
