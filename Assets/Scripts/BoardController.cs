using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class BoardController : MonoBehaviour
{
    public int AtesOzellikAtisSayisi;
    bool AtesOzelli = false;
    AtesOzellik AtesOzellik;
    Besgen Besgen;
    TopKontrol TopKontrol;
    BesgenScript BesgenScript;
    UcgenScript UcgenScript;
    SkorManager SkorManager;
    ReklamScript ReklamScript;
    public AudioClip BlokKırılmaSesi;
    public AudioClip TopSesi;
    AudioSource AudioSource;
    public DeadBox DeadBox;
    float zaman;
    public float OlumArkaPlanSayac;
    public bool OyunBitti=false;
    public Image OlumArkaPlan;
    public int BoardSpeed;
    int Gecici;
    public TextMeshProUGUI AtisSayisiText;
    public int atisSayisi =5;
    public Image BelirlenenRenk;
    public GameObject[] TopObjeleri;
    public int RandomColorNumber;
    public Sprite[] SpriteSColor; 
    public float Hiz;
    Rigidbody2D Rigidbody;
    private Vector3 TouchPosition;
    private Vector3 direction;
    Vector3 baslangicPozisyonu;
    Vector3 bitisPozisyonu;
    public PanelAyarlari PanelAyarlari;
    public FixedJoystick Joystick;
    Vector2 Movement;
    Rigidbody2D hareket;
    // Start is called before the first frame update
    void Start()
    {
        float width = Screen.width;
        float height = Screen.height;
        Debug.Log(width);
        Debug.Log(height);
        AtesOzellik = FindObjectOfType<AtesOzellik>();
        UcgenScript = FindObjectOfType<UcgenScript>();
        Besgen = FindObjectOfType<Besgen>();
        TopKontrol = FindObjectOfType<TopKontrol>();
        BesgenScript = FindObjectOfType<BesgenScript>();
        SkorManager = FindObjectOfType<SkorManager>();
        ReklamScript = FindObjectOfType<ReklamScript>();
        AudioSource = GetComponent<AudioSource>();
        AtisSayisiText.text = "X"+atisSayisi.ToString();
        baslangicPozisyonu = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
        bitisPozisyonu = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0));

        hareket = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        
        HaraketEt();
        AtisSayisiBitti();

       
        if (SkorManager.skor >= 3200 && SkorManager.skor <= 6000)
        {
            BesgenScript.BesgenYarat();   
        }
        else if (SkorManager.skor > 6300 && SkorManager.skor <= 7500)
        {
            UcgenScript.BesgenYarat();
        }
        else if (SkorManager.skor > 7550 && SkorManager.skor <= 10000)
        {
            DeadBox.KutulariYarat();
        }
        else if (SkorManager.skor > 10050 && SkorManager.skor <= 12000)
        {
            BesgenScript.BesgenYarat();
        }
        else if (SkorManager.skor > 12050 && SkorManager.skor <= 14000)
        {
            UcgenScript.BesgenYarat();
        }
        else
        {
            DeadBox.KutulariYarat();
        }

        AnaMenuyeDon();

        if (!AtesOzelli)
        {
            OncedenRengiGoster();
        }
        else
        {
            OncedenRengiGosterAtes();
        }

        
          
    }
    public void AtisSayisiBitti()
    {
        
        if (atisSayisi <= 0)
        {
            OyunBitti = true;
        }
        else
        {
            AtisSayisiText.text = "X" + atisSayisi.ToString();
        }
    }
    public void OncedenRengiGoster()
    {
        BelirlenenRenk.sprite = TopObjeleri[RandomColorNumber].GetComponent<SpriteRenderer>().sprite;

    }
    public void OncedenRengiGosterAtes()
    {
        BelirlenenRenk.sprite = TopObjeleri[6].GetComponent<SpriteRenderer>().sprite;

    }
    public void RengiBelirle()
    {
        RandomColorNumber = Random.Range(0, 6);

        gameObject.GetComponent<SpriteRenderer>().sprite = SpriteSColor[RandomColorNumber];
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "TopAtes")
        {
            AtesOzelli = true;

        }
        if(collision.tag=="deadpurple" || collision.tag == "deadorange" || collision.tag == "deadgreen" || collision.tag == "deadbrown" || collision.tag == "deadturquoise"||collision.tag=="Besgen" || collision.tag == "Ucgen")
        {
            ReklamScript.GecisliReklamGoster();
            OyunBitti = true;
            
            //Destroy(gameObject);
            Invoke("SahneyiYenidenBaslat", 3f);
        }
    }
    public void SahneyiYenidenBaslat()
    {
        PanelAyarlari.SahneyiYenidenBaslat();
    }
    public void AnaMenuyeDon()
    {
        if (OyunBitti)
        {
           
            zaman += Time.deltaTime;
            OlumArkaPlanSayac += 0.03f;
            OlumArkaPlan.color = new Color(255,255, 255, OlumArkaPlanSayac);
            gameObject.GetComponent<Collider2D>().enabled = false;
        }
        if (OlumArkaPlanSayac >= 3)
        {
            OyunBitti = false;
            OlumArkaPlan.color = new Color(255, 255, 255, OlumArkaPlanSayac);
            gameObject.GetComponent<Collider2D>().enabled = true;

        }
    }
    public void AtesEt()
    {
        if (atisSayisi > 0 )
        {
            if (!AtesOzelli)
            {
                AudioSource.PlayOneShot(TopSesi);
                GameObject Top = Instantiate(TopObjeleri[RandomColorNumber], transform.position, Quaternion.identity);
                Invoke("RengiBelirle", 0);
                AtisSayisiAzalt(1);
            }
            else
            {
                AtesOzellikAtisSayisi--;
                if (AtesOzellikAtisSayisi > 0)
                {
                    AudioSource.PlayOneShot(TopSesi);
                    GameObject Top = Instantiate(TopObjeleri[6], transform.position, Quaternion.identity);
                    
                    AtisSayisiAzalt(1);
                }
                else
                {
                    AtesOzelli = false;
                }
                
            }
                  
        }
        
    }
   
    public  void AtisSayisiArttir(int sayi)
    {
        atisSayisi += sayi;
        
    }
    public  void AtisSayisiAzalt(int sayi)
    {
        atisSayisi -= sayi;
    }
    public void HaraketEt()
    {
        
        //gameObject.transform.position = new Vector3(Mathf.Clamp())
        Movement.x = Joystick.Horizontal;
        Movement.y = Joystick.Vertical;
        hareket.MovePosition(hareket.position + Movement * Hiz * Time.deltaTime);
        float xPozisyon = Mathf.Clamp(transform.position.x, -1.9f, 1.9f);
        gameObject.transform.position = new Vector2(xPozisyon,transform.position.y);
    }

}
