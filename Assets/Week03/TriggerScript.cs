using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    [SerializeField]
    private Camera newCam;
    Camera current;

    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("Switch");
        current = Camera.current;
        current.gameObject.active = false;
        newCam.gameObject.active = true;
    }
}
