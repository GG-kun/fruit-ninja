using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TranslatableUI : MonoBehaviour, ITranslatable
{
    [Header("Language")]
    [Tooltip("Spanish word")]
    [SerializeField]
    private string spanish;
    [Tooltip("English word")]
    [SerializeField]
    private string english;

    private Text text;

    void Awake() {
        text = GetComponent<Text>();
    }

    public void SetSpanish() {
        text.text = spanish;
    }
    public void SetEnglish() {
        text.text = english;
    }
}
