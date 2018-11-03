using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text scoreText;
    public int scoreCounter = 0;
    // Use this for initialization
    void Start()
    {
        scoreText.text = "Score: " + scoreCounter;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + scoreCounter;
    }
}
