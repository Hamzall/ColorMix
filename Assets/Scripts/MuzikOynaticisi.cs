using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuzikOynaticisi : MonoBehaviour
{
    static MuzikOynaticisi Sounds = null;
    void Start()
    {
        if (Sounds != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Sounds = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }

    }
    public void SesiAyarla(float SesDegeri)
    {
        GetComponent<AudioSource>().volume = SesDegeri;
    }
}
