using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ucgen : MonoBehaviour
{
    SkorManager SkorManager;
    BoardController BoardController;
    public int sayi;
    public Sprite[] Ucgenler;
    public float BoxSpeedX;
    public float BoxSpeedY;
    float sayac;
    int SagaSolaSayac = 0;
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
        Debug.Log(BoxSpeedY);
        if (SkorManager.skor >= 6300 && SkorManager.skor < 7000)
        {
            BoxSpeedY = -2.5f;
            
        }
        if (SkorManager.skor >= 7000 && SkorManager.skor < 8500)
        {
            BoxSpeedY = -2.8f;
        }
        if (SkorManager.skor >= 8500 && SkorManager.skor < 10000)
        {
            BoxSpeedY = -3f;
        }
        if (SkorManager.skor >= 20000 && SkorManager.skor < 22000)
        {
            BoxSpeedY = -3.2f;
        }
        if (SkorManager.skor >= 22000 && SkorManager.skor < 25000)
        {
            BoxSpeedY = -3.5f;
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
            GetComponent<SpriteRenderer>().sprite = Ucgenler[BoardController.RandomColorNumber];
            SagaSolaSayac = Random.Range(0, 2);
            sayac = 0;
        }
    }

    public void SagaSolaHareket()
    {
        
        Debug.Log(SagaSolaSayac);
        if (SagaSolaSayac % 2 == 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(BoxSpeedX, BoxSpeedY, 0);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(-BoxSpeedX, BoxSpeedY, 0);
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
            Debug.Log(collision.tag);
            BoardController.AtisSayisiAzalt(2);
        }
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
