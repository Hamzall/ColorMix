using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DondurOzellik : MonoBehaviour
{
    public Sprite Dondur;
    float hiz;
    public bool SayacBaslat=false;
    public float sayac;
    BoardController BoardController;
    void Start()
    {
        BoardController = FindObjectOfType<BoardController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Board")
        {
            SayacBaslat = true;
            BoardController.GetComponent<SpriteRenderer>().sprite = Dondur;
            hiz = BoardController.Hiz;
            BoardController.Hiz = 0;
            
        }
    }
    private void Update()
    {
        if (SayacBaslat)
        {
            sayac += Time.deltaTime;
            if (sayac >= 2)
            {
                BoardController.Hiz = hiz;
                Debug.Log("Girdi");
                sayac = 0;
                SayacBaslat = false;
            }
        }
    }
}
