using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    
    
    [SerializeField] float speed = 1 ;
    [SerializeField] float turnSpeed = 100f;

    Rigidbody2D planeRigidBody;
    float turnDirection;

    CameraFollow cameraFollow;

    private void Awake()
    {
        planeRigidBody = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        cameraFollow = Camera.main.GetComponent<CameraFollow>();
        cameraFollow.Follow(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        turnDirection = Input.GetAxisRaw ("Horizontal");
        
    }

    private void FixedUpdate()
    {
        planeRigidBody.velocity = transform.up*speed;
        planeRigidBody.angularVelocity = -turnDirection * turnSpeed; 
    }


}
