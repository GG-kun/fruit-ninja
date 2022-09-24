using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ScoreUI : MonoBehaviour
{
    public void Show(Score score){
        GetComponent<Text>().text = score.GetScore().ToString();
    }
}
