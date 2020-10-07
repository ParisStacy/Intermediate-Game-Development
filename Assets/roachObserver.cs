using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roachObserver : MonoBehaviour
{
    Animator animator;
    float threshold;
    float _t;

    void Start()
    {
        animator = GetComponent<Animator>();
        animator.enabled = false;
        threshold = Random.Range(0, 5);
    }

    void Update()
    {
        _t += Time.deltaTime;
        if (_t > threshold) {
            animator.enabled = true;
        }
    }
}
