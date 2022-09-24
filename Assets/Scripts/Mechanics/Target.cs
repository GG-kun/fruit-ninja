using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : Playable
{
    private int value = 1;
    private Score score;
    private ScoreUI scoreUI;

    void Awake() {
        score = FindObjectOfType<Score>();
        scoreUI = FindObjectOfType<ScoreUI>();
    }

    public override void Selected() {
        score.Add(value);
        scoreUI.Show(score);
        base.Selected();
    }
}
