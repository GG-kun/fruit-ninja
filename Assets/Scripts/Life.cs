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
        Debug.Log("Lost");
        Time.timeScale = 0;
    }
}
