using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowDeadzone : MonoBehaviour
{
    [SerializeField]
    private GameObject target;
    [SerializeField]
    private float smoothTime;

    Vector3 velocity;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        Vector3 targetPosition = target.transform.TransformPoint(new Vector3(0, 3, -10));

        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
