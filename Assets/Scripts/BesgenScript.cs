using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BesgenScript : MonoBehaviour
{
    int RastgeleSayı;
    float zaman2;
    float zaman;
    public float KutularınOlusmaZamani;
    public bool Kapali = false;
    
    public float BoxSpeedX;
    public GameObject Besgen;
    public GameObject BesgenIns;
    
    SkorManager SkorManager;
    // Start is called before the first frame update
    void Start()
    {
        SkorManager = FindObjectOfType<SkorManager>();
    }
    public void BesgenYarat()
    {
        
        zaman += Time.deltaTime;
        
        if (zaman >= KutularınOlusmaZamani)
        {
            
            BesgenIns = Instantiate(Besgen);
            
            zaman = 0;
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        Debug.Log(collision.name);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
   
}
