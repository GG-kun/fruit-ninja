using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score: MonoBehaviour
{
    private int current;
    public void Add(int score) {
        current += score;
    }
}
