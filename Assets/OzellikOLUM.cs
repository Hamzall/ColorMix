using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OzellikOLUM : MonoBehaviour
{
    
    BoardController BoardController;
    
    // Start is called before the first frame update
    void Start()
    {
        BoardController = FindObjectOfType<BoardController>();
        
    }
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Board")
        {
            BoardController.OyunBitti = true;
            Destroy(gameObject);
        }
    }
}
