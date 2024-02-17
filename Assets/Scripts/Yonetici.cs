using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Y�netici : MonoBehaviour
{
    public GameObject altigen,top;
    public GameObject baslangicYaz�s�;
    public Transform baslangicPos;
    private bool  basla = false;


    void Start()
    {
        //Alt�gen d�n�� kodu kapat
        altigen.GetComponent<Donus>().enabled = false;
    }

   
    void Update()
    {
        //Mouse  bas�nca
        if(Input.GetMouseButtonDown(0) && !basla)
        {
            //topun pozisyonunu ba�lang�ca al
            top.transform.position = baslangicPos.position;
            top.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            //alt�gen d�n�� kodu a�
            altigen.GetComponent<Donus>().enabled = true;
            baslangicYaz�s�.SetActive(false);
            basla = true;
        }
    }
}
