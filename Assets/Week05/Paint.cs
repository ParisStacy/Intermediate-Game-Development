using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paint : MonoBehaviour
{
    public GameObject brush;
    public GameObject paint;

    void Start()
    {
                
    }

    void Update()
    {
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D mouseHit = Physics2D.Raycast(camRay.origin, camRay.direction, 100);

        if (mouseHit.collider != null) {
            brush.SetActive(true);
            brush.transform.position = mouseHit.point;

        }
    }
}
