using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public float score;
    public float pointIncreasePerSecond;
    public Text scoreDisplay;

    void Start()
    {
        score = 0f;
        //increases the score by one every second
        pointIncreasePerSecond = 1;
    }

    void Update()
    {
        //keeps putting the whole number with decimals rather than just the whole number, but hey it works
        scoreDisplay.text = (int)score + " Score";
        score += pointIncreasePerSecond * Time.deltaTime;
        if (scoreDisplay != null)
        {
            scoreDisplay.text = score.ToString();
        }
        score += pointIncreasePerSecond * Time.deltaTime;
    }
}
