using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]
    GameObject newRoom;
    [SerializeField]
    FadeInOut inOut;

    void Start()
    {
        
    }
    void Update()
    {
        
    }

    void OnMouseDown() {
        inOut.fade(newRoom);
    }
}
