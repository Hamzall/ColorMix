using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopHiziOzellik : MonoBehaviour
{
    public int AzaltilacakTopHizi;
    public int ArttirilacakTopHizi;
    TopKontrol TopKontrol;
    void Start()
    {
        TopKontrol = FindObjectOfType<TopKontrol>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == "Board" && gameObject.name == "TopHiziAzaltOzellik")
        {
            if (TopKontrol != null)
            {
                TopKontrol.hiz -= AzaltilacakTopHizi;
            }

        }
        if (collision.tag == "Board" && gameObject.name == "TopHiziArttirOzellik")
        {
            TopKontrol.hiz += ArttirilacakTopHizi;
            Debug.Log("OROSPUCOCUĞU");
        }
    }
}
