using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dondurme : MonoBehaviour
{
    public float DondurmeHizi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   void dondurme()
    {
        gameObject.GetComponent<RectTransform>().Rotate(new Vector3(0,0, DondurmeHizi));
    }
    void Update()
    {
        dondurme();
    }
}
