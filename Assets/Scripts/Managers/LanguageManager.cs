using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LanguageManager : MonoBehaviour
{
    private List<ITranslatable> translatables;

    void Start()
    {
        Translate(PlayerPrefs.GetString("language"));
    }

    public void Translate(string language)
    {
        PlayerPrefs.SetString("language", language);
        PlayerPrefs.Save();
        foreach (ITranslatable translatable in GameObject.FindObjectsOfType<MonoBehaviour>().OfType<ITranslatable>())
        {
            switch (language)
            {
                case "Español":
                    translatable.SetSpanish();
                    break;
                case "English":
                    translatable.SetEnglish();
                    break;
                default:
                    break;
            }
        }
    }
}
