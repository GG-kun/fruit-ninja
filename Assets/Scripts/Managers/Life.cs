using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    private int lives = 3;
    public void Lose() {
        lives -= 1;
        if(lives <= 0){
            Dead();
        }
    }
    public void Dead() {
        foreach (Playable playable in FindObjectsOfType<Playable>())
        {
            playable.Destroyed();
        }
        FindObjectOfType<Score>().Save();
        Time.timeScale = 0;
    }
}
