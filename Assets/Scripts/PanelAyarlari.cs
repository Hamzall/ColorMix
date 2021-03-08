using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelAyarlari : MonoBehaviour
{
    bool AcKapa = false;
    public BoardController BoardController;
    public GameObject Panel;    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AnaMenuyeDon()
    {
        SceneManager.LoadScene("Anamenu");
        Time.timeScale = 1;
    }
    public void SahneyiYenidenBaslat()
    {
        SceneManager.LoadScene("Sonsuz");
        BoardController.OlumArkaPlanSayac = 0;
        Time.timeScale = 1;
    }
    public void PaneliAcKapa()
    {
        if (!AcKapa)
        {
            Panel.SetActive(true);
            Time.timeScale = 0;
            AcKapa = true;
        }
        else
        {
            Panel.SetActive(false);
            Time.timeScale = 1;
            AcKapa = false;
        }
      
    }
}
