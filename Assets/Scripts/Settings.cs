using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Settings : MonoBehaviour
{
    public TextMeshProUGUI HighScoreText;
    public GameObject PanelSetting;
    public GameObject PanelHighScore;
    public Slider ArkaPlanSesKontrol;
    private MuzikOynaticisi MuzikOynaticisi;
    void Start()
    {
        ArkaPlanSesKontrol.value = 0.1f;
        MuzikOynaticisi = GameObject.FindObjectOfType<MuzikOynaticisi>();
    }

    // Update is called once per frame
    void Update()
    {
        MuzikOynaticisi.SesiAyarla(ArkaPlanSesKontrol.value);
    }
    public void SonsuzSahnesineGit()
    {
        SceneManager.LoadScene("Sonsuz");
        
    }
    public void PaneliAc()
    {
        PanelSetting.SetActive(true);
    }
    public void PaneliKapat()
    {
        PanelSetting.SetActive(false);
    }
    public void HighScoreGoster()
    {
        PanelHighScore.SetActive(true);
        HighScoreText.text = PlayerPrefs.GetInt("Skor").ToString();

    }
    public void HighScoreKapat()
    {
        PanelHighScore.SetActive(false);
    }
}
