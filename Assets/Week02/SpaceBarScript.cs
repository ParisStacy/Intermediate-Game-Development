using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceBarScript : MonoBehaviour
{
    private int count;
    [SerializeField]
    private int threshold;
    [SerializeField]
    private string message;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            count++;
        }

        if (count > threshold) {
            Debug.Log(message);
        }
    }
}
