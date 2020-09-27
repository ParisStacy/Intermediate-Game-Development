using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private GameManager GM;
    [SerializeField]
    private AudioClip audioClip;
    private AudioSource AudS;

    void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
        AudS = GetComponent<AudioSource>();
    }
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        GM.score++;
        AudS.Play();
        transform.position = new Vector3(100, 100, 100);
//        GameObject.Destroy(gameObject);
    }
}
