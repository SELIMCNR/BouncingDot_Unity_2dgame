using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donus : MonoBehaviour
{

    private float beklemeSüresi = 0.1f;

    void Update()
    {
        StartCoroutine(AltigenDonus()); //karotine çalýþmasý
    }


    IEnumerator AltigenDonus()
    {

        Vector2 mousePos = Camera.main.ScreenToWorldPoint( new Vector2(Input.mousePosition.x,0));   

        if (Input.GetMouseButtonDown(0) && mousePos.x>0)
        {
            // Sað týklanýnca farede döndür çemberi.
            transform.Rotate(0, 0, -30); //sola döndür 30 derece
            //IEnumeratorde yield return olmalý
            yield return new WaitForSeconds(beklemeSüresi); // ve burda 1 saniye bekleme iþlemi yapýyor
            transform.Rotate(0, 0, -30); //sola döndür 30 derece
        }
        else if (Input.GetMouseButtonDown(0) && mousePos.x<0) 
        {
            // Sola týklanýnca farede döndür çemberi.
            transform.Rotate(0, 0, 30); //saða döndür 30 derece
            yield return new WaitForSeconds(beklemeSüresi); // ve burda 1 saniye bekleme iþlemi yapýyor
            transform.Rotate(0, 0, 30); //saða döndür 30 derece

        }

    }


}
