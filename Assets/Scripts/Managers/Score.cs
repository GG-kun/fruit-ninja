using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score: MonoBehaviour
{
    private int current;
    public void Add(int score) {
        current += score;
    }

    public int GetScore() {
        return current;
    }

    public void Save() {
        Scoreboard.AddScore(this);
        if(Scoreboard.Save()){
            Debug.Log("Saved");
        }
    }
}
