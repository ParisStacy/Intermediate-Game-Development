using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public int speed;
    private Vector2 move;

    public Sprite[] walkAnimation = new Sprite[2];
    public float walkAnimationFPS;
    private int currentFrame;
    private float previousFrameTime;

    public AudioSource walkingOverHere;

    private bool moving;
    private bool audioCuePlayed;

    void Start()
    {
        
    }

    void Update()
    {
        move.x = Input.GetAxis("Horizontal");
        move.y = Input.GetAxis("Vertical");

        moving = (move != Vector2.zero);
        if (moving) gameObject.GetComponent<SpriteRenderer>().flipX = (move.x > 0) ? true : false;

        gameObject.GetComponent<SpriteRenderer>().sprite = walkAnimation[currentFrame];

        if (transform.position.y > -.87f) move.y = -1;
        if (transform.position.y < -1.33f) move.y = 1;

        transform.Translate(new Vector3(move.x, move.y, 0) * Time.deltaTime * speed);

        if (moving) {
            if (Time.time - previousFrameTime > 1 / walkAnimationFPS) {
                previousFrameTime = Time.time;
                currentFrame++;
                if (currentFrame > walkAnimation.Length - 1) currentFrame = 0;
            }
        } else {
            currentFrame = 0;
        }

        if (transform.position.x > -4 && !audioCuePlayed) {
            audioCuePlayed = true;
            walkingOverHere.Play();
        }
    }
}
