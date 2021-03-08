using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopKontrol : MonoBehaviour
{
    public float hiz = 5f;
    Besgen Besgen;
    Ucgen Ucgen;
    BesgenScript BesgenScript;
    AudioSource AudioSource;
    SkorManager SkorManager;
    GameObject go;
    BoardController Board;
    // Start is called before the first frame update
    void Start()
    {
        Ucgen = FindObjectOfType<Ucgen>();
        Besgen = FindObjectOfType<Besgen>();
        BesgenScript = FindObjectOfType<BesgenScript>();
        AudioSource = GetComponent<AudioSource>();
        Board = FindObjectOfType<BoardController>();
        SkorManager = FindObjectOfType<SkorManager>();
        go = GameObject.FindWithTag("deadbox");
      //  Board = GetComponent<BoardController>();
    }

    // Update is called once per frame
    void Update()
    {

        Hareket();

        if (SkorManager.skor >= 2000)
        {
            hiz = 20f;
        }
    }
    void Hareket()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, hiz, 0);
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="deadbrown"|| collision.tag == "deadturquoise" || collision.tag == "deadgreen" || collision.tag == "deadpurple" || collision.tag == "deadorange")
        {
            if (gameObject.tag == "TopAtes")
            {
                Board.GetComponent<AudioSource>().PlayOneShot(Board.BlokKırılmaSesi);
                SkorManager.SkorLevelBelirleme();
                Board.AtisSayisiArttir(1);
                Destroy(go);
                Destroy(gameObject);
            }
        }
        
        if (collision.tag == "Besgen")
        {
            if (gameObject.tag == "TopAtes")
            {
                Board.GetComponent<AudioSource>().PlayOneShot(Board.BlokKırılmaSesi);
                SkorManager.SkorLevelBelirleme();
                Board.AtisSayisiArttir(1);
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
            if (gameObject.tag == "TopMix" && !(collision.tag == "Board"))
            {
                Board.GetComponent<AudioSource>().PlayOneShot(Board.BlokKırılmaSesi);
                SkorManager.SkorLevelBelirleme();
                Board.AtisSayisiArttir(1);
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
            if (collision.GetComponent<SpriteRenderer>().sprite == Besgen.Besgenler[1] && gameObject.tag == "TopOrange")
            {
                Board.GetComponent<AudioSource>().PlayOneShot(Board.BlokKırılmaSesi);
                SkorManager.SkorLevelBelirleme();
                Board.AtisSayisiArttir(2);
                Destroy(gameObject);
                collision.gameObject.SetActive(false);
            }
            if (collision.GetComponent<SpriteRenderer>().sprite == Besgen.Besgenler[4] && gameObject.tag == "TopTurquoise")
            {
                Board.GetComponent<AudioSource>().PlayOneShot(Board.BlokKırılmaSesi);
                SkorManager.SkorLevelBelirleme();
                Board.AtisSayisiArttir(2);
                Destroy(gameObject);
                collision.gameObject.SetActive(false);
            }
            if (collision.GetComponent<SpriteRenderer>().sprite == Besgen.Besgenler[2] && gameObject.tag == "TopPurple")
            {
                Board.GetComponent<AudioSource>().PlayOneShot(Board.BlokKırılmaSesi);
                SkorManager.SkorLevelBelirleme();
                Board.AtisSayisiArttir(2);
                Destroy(gameObject);
                collision.gameObject.SetActive(false);
            }
            if (collision.GetComponent<SpriteRenderer>().sprite == Besgen.Besgenler[3] && gameObject.tag == "TopBrown")
            {
                Board.GetComponent<AudioSource>().PlayOneShot(Board.BlokKırılmaSesi);
                SkorManager.SkorLevelBelirleme();
                Board.AtisSayisiArttir(2);
                Destroy(gameObject);
                collision.gameObject.SetActive(false);
            }
            if (collision.GetComponent<SpriteRenderer>().sprite == Besgen.Besgenler[0] && gameObject.tag == "TopGreen")
            {
                Board.GetComponent<AudioSource>().PlayOneShot(Board.BlokKırılmaSesi);
                SkorManager.SkorLevelBelirleme();
                Board.AtisSayisiArttir(2);
                Destroy(gameObject);
                collision.gameObject.SetActive(false);
            }




        }
        if (collision.tag == "Ucgen")
        {
            if (gameObject.tag == "TopAtes")
            {
                Board.GetComponent<AudioSource>().PlayOneShot(Board.BlokKırılmaSesi);
                SkorManager.SkorLevelBelirleme();
                Board.AtisSayisiArttir(1);
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
            if (gameObject.tag == "TopMix" && !(collision.tag == "Board"))
            {
                Board.GetComponent<AudioSource>().PlayOneShot(Board.BlokKırılmaSesi);
                SkorManager.SkorLevelBelirleme();
                Board.AtisSayisiArttir(1);
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
            if (collision.GetComponent<SpriteRenderer>().sprite == Ucgen.Ucgenler[1] && gameObject.tag == "TopOrange")
            {
                Board.GetComponent<AudioSource>().PlayOneShot(Board.BlokKırılmaSesi);
                SkorManager.SkorLevelBelirleme();
                Board.AtisSayisiArttir(2);
                Destroy(gameObject);
                collision.gameObject.SetActive(false);
            }
            if (collision.GetComponent<SpriteRenderer>().sprite == Ucgen.Ucgenler[4] && gameObject.tag == "TopTurquoise")
            {
                Board.GetComponent<AudioSource>().PlayOneShot(Board.BlokKırılmaSesi);
                SkorManager.SkorLevelBelirleme();
                Board.AtisSayisiArttir(2);
                Destroy(gameObject);
                collision.gameObject.SetActive(false);
            }
            if (collision.GetComponent<SpriteRenderer>().sprite == Ucgen.Ucgenler[2] && gameObject.tag == "TopPurple")
            {
                Board.GetComponent<AudioSource>().PlayOneShot(Board.BlokKırılmaSesi);
                SkorManager.SkorLevelBelirleme();
                Board.AtisSayisiArttir(2);
                Destroy(gameObject);
                collision.gameObject.SetActive(false);
            }
            if (collision.GetComponent<SpriteRenderer>().sprite == Ucgen.Ucgenler[3] && gameObject.tag == "TopBrown")
            {
                Board.GetComponent<AudioSource>().PlayOneShot(Board.BlokKırılmaSesi);
                SkorManager.SkorLevelBelirleme();
                Board.AtisSayisiArttir(2);
                Destroy(gameObject);
                collision.gameObject.SetActive(false);
            }
            if (collision.GetComponent<SpriteRenderer>().sprite == Ucgen.Ucgenler[0] && gameObject.tag == "TopGreen")
            {
                Board.GetComponent<AudioSource>().PlayOneShot(Board.BlokKırılmaSesi);
                SkorManager.SkorLevelBelirleme();
                Board.AtisSayisiArttir(2);
                Destroy(gameObject);
                collision.gameObject.SetActive(false);
            }




        }
        if (collision.tag == "deadturquoise")
        {
            if (!(gameObject.tag == "TopTurquoise"))
            {
                Destroy(gameObject);
                
            }

        }
        if (collision.tag == "deadbrown")
        {
            if (!(gameObject.tag == "TopBrown"))
            {
                Destroy(gameObject);
                
            }

        }
        if (collision.tag == "deadgreen" )
        {
            if (!(gameObject.tag == "TopGreen"))
            {
                Destroy(gameObject);
                
            }

        }
        if (collision.tag == "deadpurple")
        {
            if (!(gameObject.tag == "TopPurple"))
            {
                Destroy(gameObject);
                
            }

        }
        if (collision.tag == "deadorange")
        {
            if (!(gameObject.tag == "TopOrange"))
            {
                Destroy(gameObject);
                
            }

        }
        if (collision.tag=="deadgreen" && gameObject.tag == "TopGreen")
        {
            Board.GetComponent<AudioSource>().PlayOneShot(Board.BlokKırılmaSesi);
            SkorManager.SkorLevelBelirleme();
            Board.AtisSayisiArttir(1);
            Destroy(go);
            Destroy(gameObject);
        }
        if (collision.tag == "deadbrown" && gameObject.tag == "TopBrown")
        {
            Board.GetComponent<AudioSource>().PlayOneShot(Board.BlokKırılmaSesi);
            SkorManager.SkorLevelBelirleme();
            Board.AtisSayisiArttir(1);
            Destroy(go);
            Destroy(gameObject);
        }
        if (collision.tag == "deadturquoise" && gameObject.tag == "TopTurquoise")
        {
            Board.GetComponent<AudioSource>().PlayOneShot(Board.BlokKırılmaSesi);
            SkorManager.SkorLevelBelirleme();
            Board.AtisSayisiArttir(1);
            Destroy(go);
            Destroy(gameObject);
        }
        if (collision.tag == "deadpurple" && gameObject.tag == "TopPurple")
        {
            Board.GetComponent<AudioSource>().PlayOneShot(Board.BlokKırılmaSesi);
            SkorManager.SkorLevelBelirleme();
            Board.AtisSayisiArttir(1);
            Destroy(go);
            Destroy(gameObject);

        }
        if (collision.tag == "deadorange" && gameObject.tag == "TopOrange")
        {
            Board.GetComponent<AudioSource>().PlayOneShot(Board.BlokKırılmaSesi);
            SkorManager.SkorLevelBelirleme();
            Board.AtisSayisiArttir(1);
            Destroy(go);
            Destroy(gameObject);

        }
        if (gameObject.tag == "TopMix" && !(collision.tag=="Board"))
        {
            Board.GetComponent<AudioSource>().PlayOneShot(Board.BlokKırılmaSesi);
            SkorManager.SkorLevelBelirleme();
            Board.AtisSayisiArttir(1);
            Destroy(go);
            Destroy(gameObject);
        }
    }
    
}
