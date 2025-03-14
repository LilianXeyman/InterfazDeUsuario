using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class CambiarIdioma : MonoBehaviour
{
    int currentLang = 0;

    void Start()
    {
        //LocalizationSettings.AvailableLocales.Locales= /Esto es un Array 0=ingles 1=italiano 2=español //Buacar el idioma en el que estas
        UnityEngine.Localization.Locale searcher = LocalizationSettings.AvailableLocales.Locales[currentLang];
        //Buacar el idioma en el que estas LocalizationSettings.SelectedLocale idioma seleccionado
        while (LocalizationSettings.SelectedLocale != searcher && currentLang < LocalizationSettings.AvailableLocales.Locales.Count)
        { 
            currentLang++;
            searcher = LocalizationSettings.AvailableLocales.Locales[currentLang];
        }
    }
    public void NextLang()
    {
        currentLang++;
        if (currentLang > LocalizationSettings.AvailableLocales.Locales.Count - 1)
        {
            currentLang = 0;
        }
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[currentLang];
    }
    public void PrevLang()
    {
        currentLang--;
        if (currentLang < 0)
        {
            currentLang = LocalizationSettings.AvailableLocales.Locales.Count - 1;//Count te da 3 y tenemos 2 entonces hacemos count-1
        }
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales [currentLang];
    }
}
