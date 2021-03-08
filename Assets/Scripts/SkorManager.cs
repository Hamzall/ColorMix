using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SkorManager : MonoBehaviour
{
    BesgenScript BesgenScript;
    public BoardController BoardController;
    public DeadBox DeadBox1;
    public  int skor=0;
    public  TextMeshProUGUI ScorText;
    public TextMeshProUGUI TotalScorText;
    void Start()
    {
        BesgenScript = FindObjectOfType<BesgenScript>();
        //PlayerPrefs.DeleteAll();
        ScorText.text = PlayerPrefs.GetInt("Skor").ToString();
        TotalScorText.text = PlayerPrefs.GetInt("Skor").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale !=0)
        {
            skor = skor + 1;
            
        }
        TotalScorText.text = PlayerPrefs.GetInt("Skor").ToString();


        Skor();
        BoardHizArttir();

    }
    public  void Skor()
    {
        
        ScorText.text = skor.ToString();
        
        
        if (skor >= PlayerPrefs.GetInt("Skor"))
        {
            Debug.Log(PlayerPrefs.GetInt("Skor"));
            PlayerPrefs.SetInt("Skor", skor);
            TotalScorText.text = PlayerPrefs.GetInt("Skor").ToString();
        }
    }
    public void BoardHizArttir()
    {
        
        if (skor == 2000)
        {
            BoardController.Hiz = BoardController.Hiz+(BoardController.Hiz/6);
            Debug.Log(BoardController.Hiz);
        }
        else if (skor == 4000)
        {
            BoardController.Hiz = BoardController.Hiz + (BoardController.Hiz / 6);
            Debug.Log(BoardController.Hiz);
        }
        else if (skor == 6000)
        {
            BoardController.Hiz = BoardController.Hiz + (BoardController.Hiz / 6);
            Debug.Log(BoardController.Hiz);
        }
        else if (skor == 8000)
        {
            BoardController.Hiz = BoardController.Hiz + (BoardController.Hiz / 6);
            Debug.Log(BoardController.Hiz);
        }
        else if (skor == 10000)
        {
            BoardController.Hiz = BoardController.Hiz + (BoardController.Hiz / 6);
            Debug.Log(BoardController.Hiz);
        }
        else if (skor == 12000)
        {
            BoardController.Hiz = BoardController.Hiz + (BoardController.Hiz / 6);
            Debug.Log(BoardController.Hiz);
        }
        else if (skor == 14000)
        {
            BoardController.Hiz = BoardController.Hiz + (BoardController.Hiz / 6);
            Debug.Log(BoardController.Hiz);
        }
        else if (skor == 16000)
        {
            BoardController.Hiz = BoardController.Hiz + (BoardController.Hiz / 6);
            Debug.Log(BoardController.Hiz);
        }

    }
    public void SkorLevelBelirleme()
    {
        
        if(skor>1000 && skor <= 2000)
        {
            DeadBox1.LevelBelirleme();
            
        }
        else if (skor > 2000 && skor <= 3000)
        {

            DeadBox1.LevelBelirleme();
            
        }
        else if (skor > 3000 && skor <= 4000)
        {

            DeadBox1.LevelBelirleme();
            
        }
        else if (skor > 4000 && skor <= 5000)
        {

            DeadBox1.LevelBelirleme();

        }
        else if (skor > 6000 && skor <= 7000)
        {

            DeadBox1.LevelBelirleme();
            DeadBox1.KutularınOlusmaZamani += 0.02f;
            
        }
        else if (skor > 7000 && skor <= 8000)
        {

            DeadBox1.LevelBelirleme();
            DeadBox1.KutularınOlusmaZamani += 0.03f;
           
        }
        else if (skor > 8000 && skor <= 9000)
        {

            DeadBox1.LevelBelirleme();
            DeadBox1.KutularınOlusmaZamani += 0.04f;
            
        }
        else if (skor > 9000 && skor <= 10000)
        {

            DeadBox1.LevelBelirleme();
            DeadBox1.KutularınOlusmaZamani += 0.05f;
            
        }

    }
}
