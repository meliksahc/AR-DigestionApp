using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageScript : MonoBehaviour
{

    [HideInInspector] public List<Text> SahnelerdekiTextler;
    public List<SahnedekiCevirici> Ceviriler;
    
    void Start()
    {

        foreach (Text items in Resources.FindObjectsOfTypeAll(typeof(Text)))
        {
            SahnelerdekiTextler.Add(items);
        }
        
    }

    public void Cevir(string CevirilicekDil)
    {
        for (int i = 0; i < Ceviriler.Count; i++)
        {
            for (int s = 0; s < SahnelerdekiTextler.Count; s++)
            {
                if (CevirilicekDil == "Turkce")
                {

                    if (Ceviriler[i].Turkce == SahnelerdekiTextler[s].text)
                    {

                        SahnelerdekiTextler[s].text = Ceviriler[i].İngilizce;
                    }
                }
                else
                {
                    if (Ceviriler[i].İngilizce == SahnelerdekiTextler[s].text)
                    {

                        SahnelerdekiTextler[s].text = Ceviriler[i].Turkce;
                    }
                }


            }

        }
    }

    public void DilDegistir(string Dil)
    {
        Cevir(Dil);
    }

    [System.Serializable]
    public class SahnedekiCevirici
    {
        public string Turkce;
        public string İngilizce;

        public SahnedekiCevirici(string turkcesi, string ingilizcesi)
        {
            Turkce = turkcesi;
            İngilizce = ingilizcesi;
        }
    }

}
