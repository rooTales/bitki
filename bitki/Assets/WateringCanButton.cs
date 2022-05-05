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
        Debug.Log(eventData);
        
        Ray ray = cam.ScreenPointToRay(Helpers.ScreenToWorldPosition(eventData.position, cam, eventData.position.y));

        if(Physics.Raycast(ray, out var hitInfo))
        {
            if(hitInfo.collider.gameObject == wateringCan)
            {
                Debug.Log("dog");
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
