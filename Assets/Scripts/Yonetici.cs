using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yönetici : MonoBehaviour
{
    public GameObject altigen,top;
    public GameObject baslangicYazýsý;
    public Transform baslangicPos;
    private bool  basla = false;


    void Start()
    {
        //Altýgen dönüþ kodu kapat
        altigen.GetComponent<Donus>().enabled = false;
    }

   
    void Update()
    {
        //Mouse  basýnca
        if(Input.GetMouseButtonDown(0) && !basla)
        {
            //topun pozisyonunu baþlangýca al
            top.transform.position = baslangicPos.position;
            top.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            //altýgen dönüþ kodu aç
            altigen.GetComponent<Donus>().enabled = true;
            baslangicYazýsý.SetActive(false);
            basla = true;
        }
    }
}
