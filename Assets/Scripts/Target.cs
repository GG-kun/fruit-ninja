using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : Playable
{
    private int score = 1;
    public override void HittedByPlayer() {
        FindObjectOfType<Score>().Add(score);
    }
    public override void Hitted() {
        FindObjectOfType<Life>().Lose();
        base.Hitted();
    }
}
