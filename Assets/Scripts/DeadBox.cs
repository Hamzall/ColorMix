using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadBox : MonoBehaviour
{
    public float KutularınOlusmaZamani=-1.8f;
    int gecici=7;
    public bool Kapali=false;
    private GameObject Kutular;
    public float BoxSpeed;
    float height;
    float width;
    float zaman;
    int RastgeleSayı;


    public GameObject[] OlecekKutular;
    public static DeadBox ins;
    void Start()
    {
        width = Screen.width;
        height = Screen.height;
        if (ins != null)
        {
            ins = this;
        }
    }
    public  void LevelBelirleme()
    {
        BoxSpeed -= 2f*Time.deltaTime;
        
    }
    // Update is called once per frame
    void Update()
    {
       // KutulariYarat();
        
    }

    public void KutulariYarat()
    {
            zaman -= Time.deltaTime;
            if (zaman < KutularınOlusmaZamani)
            {
                 RastgeleSayı= Random.Range(0, 6);
            Debug.Log(RastgeleSayı + " Rastgele sayı");

                if (RastgeleSayı != gecici)
                {
                Debug.Log("Esit degiller");

                Kutular = Instantiate(OlecekKutular[RastgeleSayı], new Vector3(0, 4, 0), Quaternion.identity);
                    Kutular.transform.localScale = new Vector3(width / (width*1.2f), height / (height * 1.2f));
                    Kutular.GetComponent<Rigidbody2D>().velocity = new Vector3(0, BoxSpeed, 0);

                    zaman = 0;
                }
                else
                {
                Debug.Log("Esit");
                RastgeleSayı = Random.Range(0, 6);
                Debug.Log(RastgeleSayı + " Rastgele sayı");
                Kutular = Instantiate(OlecekKutular[RastgeleSayı], new Vector3(0, 4, 0), Quaternion.identity);
                Kutular.transform.localScale = new Vector3(width / (width * 1.2f), height / (height * 1.2f));
                Kutular.GetComponent<Rigidbody2D>().velocity = new Vector3(0, BoxSpeed, 0);
                zaman = 0;

                }

                gecici = RastgeleSayı;
                Debug.Log(gecici + " gecici sayı");

        }
    }

}
