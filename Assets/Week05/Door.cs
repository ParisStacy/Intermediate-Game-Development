using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]
    GameObject newRoom;
    [SerializeField]
    FadeInOut inOut;

    AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }
    void Update()
    {
        
    }

    void OnMouseDown() {
        inOut.fade(newRoom);
        source.Play();
    }
}
