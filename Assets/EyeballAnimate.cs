using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeballAnimate : MonoBehaviour
{

    [Header("Iris")]
    [SerializeField]
    float constraint;
    [SerializeField]
    float smoothing;

    Vector3 origin;
    Vector3 tPos;

    GameObject parent;

    void Start() {
        origin = transform.position;
        parent = transform.parent.gameObject;
    }

    void Update()
    {
        //Iris//
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 1000f);
        Vector3 mousePosition = hit.transform.position;
        Vector3 direction = (mousePosition - origin).normalized;
        tPos = origin + (direction * constraint);
        transform.position = Vector3.Lerp(transform.position, tPos, smoothing);

        //Eyeball//

    }
}
