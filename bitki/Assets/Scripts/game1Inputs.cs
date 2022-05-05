using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class game1Inputs : MonoBehaviour,IPointerDownHandler
{
    public GameObject water;
    private Rigidbody body;
    public Vector3 force;
    private bool isGround;
    public void OnPointerDown(PointerEventData eventData)
    {
        if (isGround)
        {
            body.AddForce(force);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        body = water.GetComponent(typeof(Rigidbody)) as Rigidbody;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(water.transform.position.y < 1.0f)
        {
            isGround = true;
        }
        else
        {
            isGround = false;
        }
        Debug.Log(isGround);
    }
}
