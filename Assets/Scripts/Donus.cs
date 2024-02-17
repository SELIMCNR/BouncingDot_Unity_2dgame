using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donus : MonoBehaviour
{

    private float beklemeS�resi = 0.1f;

    void Update()
    {
        StartCoroutine(AltigenDonus()); //karotine �al��mas�
    }


    IEnumerator AltigenDonus()
    {

        Vector2 mousePos = Camera.main.ScreenToWorldPoint( new Vector2(Input.mousePosition.x,0));   

        if (Input.GetMouseButtonDown(0) && mousePos.x>0)
        {
            // Sa� t�klan�nca farede d�nd�r �emberi.
            transform.Rotate(0, 0, -30); //sola d�nd�r 30 derece
            //IEnumeratorde yield return olmal�
            yield return new WaitForSeconds(beklemeS�resi); // ve burda 1 saniye bekleme i�lemi yap�yor
            transform.Rotate(0, 0, -30); //sola d�nd�r 30 derece
        }
        else if (Input.GetMouseButtonDown(0) && mousePos.x<0) 
        {
            // Sola t�klan�nca farede d�nd�r �emberi.
            transform.Rotate(0, 0, 30); //sa�a d�nd�r 30 derece
            yield return new WaitForSeconds(beklemeS�resi); // ve burda 1 saniye bekleme i�lemi yap�yor
            transform.Rotate(0, 0, 30); //sa�a d�nd�r 30 derece

        }

    }


}
