using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycasting101 : MonoBehaviour
{
    public float detectionDistance = 2.2f;
    public float speed = 4f;

    void Update() {
        Ray2D roombaRay = new Ray2D(transform.position, transform.up);
        Debug.DrawRay(roombaRay.origin, roombaRay.direction * detectionDistance, Color.red);
        if (Physics2D.Raycast(roombaRay.origin, roombaRay.direction, detectionDistance)) {
            int randomNumber = Random.Range(0, 1);
            if (randomNumber == 0) {
                transform.Rotate(new Vector3(0, 0, 90));
            } else {
                transform.Rotate(new Vector3(0, 0, -90));
            }
        } else {
            transform.Translate(0, Time.deltaTime * speed, 0);
        }
    }
}
