using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        
    }
    void Update()
    {
        transform.position = new Vector3(Mathf.Lerp(transform.position.x, player.transform.position.x, .05f), 0, 0);
        if (player.transform.position.x < -7.5f) transform.position = new Vector3(-7.5f, 0, 0);
        if (player.transform.position.x > 0) transform.position = new Vector3(0, 0, 0);
    }
}
