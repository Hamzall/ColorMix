using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OzelikleriAktifEt : MonoBehaviour
{
    public GameObject[] Ozellikler;
    bool OzelliklerKontrol=false;
    int RastgeleSayi;
    int RastgeleSayi1;
    int RastgeleSayi2;
    static int OzellikSira = 0;

    float zaman;
    public float OlusmaZamani;
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(RastgeleSayi + " Rasgtgele Sayi" + " " + zaman + " ZAman");
        OzellikleriOlustur();
        
    }
    public void OzellikleriOlustur()
    {
        zaman += Time.deltaTime;
        if (zaman >= OlusmaZamani)
        {
            RastgeleSayi2 = Random.Range(-2, 2); 
            GameObject OlusturanNesne = Instantiate(Ozellikler[OzellikSira], new Vector3(RastgeleSayi2, 4, 0), Quaternion.identity);
            OzellikSira++;
            if (OzellikSira == 4)
            {
                OzellikSira = 0;
            }
            zaman = 0;
        }     
    }
}
