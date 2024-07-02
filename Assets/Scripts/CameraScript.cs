using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraScript: MonoBehaviour
{




    public Transform Position;
    public Transform LookPosition;

    public float smoothTime = 0.3f;
    private Vector3 velocity = Vector3.zero;
    public float rotationSpeed = 5.0f;


    void LateUpdate()
    {
  
        Vector3 desiredPosition = Position.position;

        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothTime);

        transform.position = smoothedPosition;


        Quaternion desiredRotation = Quaternion.LookRotation(LookPosition.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, desiredRotation, rotationSpeed * Time.deltaTime);
    }
}


