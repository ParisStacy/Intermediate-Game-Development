using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text scoreText;

    void Start()
    {
        
    }

    void Update()
    {
        scoreText.text = score.ToString();
    }
}
