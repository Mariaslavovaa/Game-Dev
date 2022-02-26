using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target;


    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, -10f);

    }
}


/*
 * 
public class CameraFollow : MonoBehaviour
{
    public float FollowSpeed = 2f;
    public Transform target;



    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = new Vector3(target.newPosition.x, target.newPosition.y, -10f);
        transform.position = Vector3.Slerp(transform.position, newPosition, FollowSpeed*Time.deltaTime);
    }
} 
 * 
 */