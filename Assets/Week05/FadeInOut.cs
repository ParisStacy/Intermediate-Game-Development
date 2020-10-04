using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInOut : MonoBehaviour
{
    Image black;
    float _t;
    bool active = false;
    GameObject _nextRoom;

    void Start()
    {
        black = GetComponent<Image>();
    }

    void Update()
    {
        _t += Time.deltaTime;

        if (active) {

            if (_t > 1)
                Camera.main.transform.position = _nextRoom.transform.position;
            if (_t > 2)
                active = false;

            Color tempColor = Color.black;
            tempColor.a = Mathf.PingPong(_t, 1);
            black.color = tempColor;
        }
    }

    public void fade(GameObject newRoom) {
        active = true;
        _t = 0;
        _nextRoom = newRoom;
    }
}
