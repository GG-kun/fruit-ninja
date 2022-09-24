using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageButton : MonoBehaviour
{
    private int currentLanguageIndex = 0;
    private List<string> languages = new List<string>{
        "Español",
        "English"
    };

    public void NextLanguage() {
        currentLanguageIndex = (currentLanguageIndex+1)%languages.Count;
        FindObjectOfType<LanguageManager>().Translate(languages[currentLanguageIndex]);
    }
}
