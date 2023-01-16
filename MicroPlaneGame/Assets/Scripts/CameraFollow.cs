using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Transform target;
    Vector3 offset;
    bool isFollow;
    [SerializeField] float smoothTime = 1f;
    Vector3 velocity = Vector3.zero;
    void Start()
    {


    }


    // void Update()
    // {
    //     if(isFollow)
    //     {
    //     Vector3 targetPosition = target.position + offset;
    //     targetPosition.z = transform.position.z;
    //     transform.position = targetPosition;
    //     transform.position = Vector3.SmoothDamp(transform.position,targetPosition,ref velocity,smoothTime);

    //     }       
    // }

    void FixedUpdate() 
    {
        if(isFollow)
        {
        Vector3 targetPosition = target.position + offset;
        targetPosition.z = transform.position.z;
        //transform.position = targetPosition;
        transform.position = Vector3.SmoothDamp(transform.position,targetPosition,ref velocity,smoothTime);

        }      
    }


    public void Follow(GameObject player)
    {
        target = player.transform;
        offset = transform.position - target.position;
        isFollow = true;
    }

    public void UnFollow()
    {
        isFollow = false;
    }

}
