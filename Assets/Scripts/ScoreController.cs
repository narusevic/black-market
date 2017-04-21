using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GUIText))]
public class ScoreController : MonoBehaviour
{
    public GUIText scoreCounter;
    public int score;

	// Use this for initialization
	public void Start ()
	{
        scoreCounter = GetComponent<GUIText>();
        score = 0;
        UpdateScore();
	}

    public void AddScore(int newScore)
    {
        score += newScore;
        UpdateScore();
    }

	// Update is called once per frame
	void UpdateScore()
	{
	    scoreCounter.text = "Score: " + score;
	}
}
