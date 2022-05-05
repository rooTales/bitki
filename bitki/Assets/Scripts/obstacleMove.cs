using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleMove : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject water;
    public Vector3 speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        obstacle.transform.position += speed * Time.deltaTime;

    if(obstacle.transform.position.x < -12)
        {
            obstacle.transform.position += new Vector3(30, 0, 0);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.gameObject == water)
        {
            Debug.Log("doglan?r");
        }
    }
}
