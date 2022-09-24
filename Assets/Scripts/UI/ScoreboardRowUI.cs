using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreboardRowUI : MonoBehaviour
{
    [Header("Text")]
    [Tooltip("Text for the player name")]
    [SerializeField]
    private Text nameRow;
    [Tooltip("Text for the player score")]
    [SerializeField]
    private Text scoreRow;
    public void SetName(string name) {
        nameRow.text = name;
    }
    public void SetScore(string score) {
        scoreRow.text = score;
    }
}
