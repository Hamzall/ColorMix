using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Besgen : MonoBehaviour
{
    SkorManager SkorManager;
    BoardController BoardController;
    public int sayi;
    public Sprite[] Besgenler;
    public float BoxSpeedX;
    public float BoxSpeedY;
    float sayac;
    int SagaSolaSayac=0;
    public float RenginDegismeZamanı;
    int RandomSayi;
    // Start is called before the first frame update
    void Start()
    {
        SkorManager = FindObjectOfType<SkorManager>();
        BoardController = FindObjectOfType<BoardController>();
        int PositionRandom = Random.Range(-2, 2);
        transform.position = new Vector3(PositionRandom, 7, 0);
    }

    // Update is called once per frame
    void Update()
    {

        if (SkorManager.skor>=3200 && SkorManager.skor < 3600)
        {
            BoxSpeedY = -2.5f;
            
        }
        if (SkorManager.skor >= 3600 && SkorManager.skor < 4000)
        {
            BoxSpeedY = -3f;
        }
        if (SkorManager.skor >= 4000 && SkorManager.skor < 4500)
        {
            BoxSpeedY = -3.2f;
        }
        if (SkorManager.skor >= 5000 && SkorManager.skor < 6000)
        {
            BoxSpeedY = -3.5f;
        }
        if (SkorManager.skor >= 10400 && SkorManager.skor < 12000)
        {
            BoxSpeedY = -4.1f;
        }
        if (SkorManager.skor >= 12000 && SkorManager.skor < 13000)
        {
            BoxSpeedY = -4.2f;
        }
        if (SkorManager.skor >= 13000 && SkorManager.skor < 14000)
        {
            BoxSpeedY = -4.3f;
        }
        RenkDegistir();
        SagaSolaHareket();
        transform.Rotate(new Vector3(0, 0, 1f));
        
    }
    public void RenkDegistir()
    {
        sayac += Time.deltaTime;
        if (sayac >= RenginDegismeZamanı)
        {
            GetComponent<SpriteRenderer>().sprite = Besgenler[BoardController.RandomColorNumber];
            sayac = 0;
        }
    }
    
    public void SagaSolaHareket()
    {
        if (SagaSolaSayac % 2 == 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, BoxSpeedY, 0);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(-0, BoxSpeedY, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Kenar")
        {
            SagaSolaSayac++;
        }
        if (collision.tag == "AltKenar")
        {
            
            BoardController.AtisSayisiAzalt(2);
        }
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
