using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtısOzellik : MonoBehaviour
{
    public int EklenecekAtisSayisi;
    BoardController BoardController;
    void Start()
    {
        BoardController = FindObjectOfType<BoardController>();
    }
    private void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, -4);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Board")
        {
            BoardController.atisSayisi += EklenecekAtisSayisi;
            Destroy(gameObject);
        }
    }
}
