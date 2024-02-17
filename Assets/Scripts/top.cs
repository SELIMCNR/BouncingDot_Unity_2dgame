using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class top : MonoBehaviour
{

    private Rigidbody2D topRb;
    private SpriteRenderer topRenderer;
    public float ziplamaGücü;
    public Color color1, color2, color3, color4, color5, color6;
    public Text skorYazisi,rekorYazisi;
    private int skor,rekor;

    void Start()
    {
        topRb = GetComponent<Rigidbody2D>(); // yerçekimi
        topRenderer = GetComponent<SpriteRenderer>(); //render iþlemi

        if (PlayerPrefs.HasKey("rekor"))
        {
            //böyle bir veri var ise 
            rekor = PlayerPrefs.GetInt("rekor");  // rekoru alýr kayýttan 
            rekorYazisi.text = "Rekor :" + rekor.ToString();
        }
        else
        {
            rekor = 0;
        }
      
        //Unityde clear all prefecs ile var olan veri silinir.
    }



    private void OnCollisionEnter2D(Collision2D temas)
    {
        if(temas.gameObject.tag == "zemin")
        {
            //Kenara deðince top zýpla
            topRb.AddForce(Vector2.up * ziplamaGücü/2, ForceMode2D.Impulse);

        }


        //Tüm kenarlarý seç ve center of children yap hepsi ayný yöne döner.
        if (temas.gameObject.tag =="kenar")
        {
            //Kenara deðince top zýpla
            topRb.AddForce(Vector2.up * ziplamaGücü, ForceMode2D.Impulse);

            if (topRenderer.color == temas.gameObject.GetComponent<SpriteRenderer>().color)
            { //Topun rengi ile kenar rengi eþitse
                GetComponent<AudioSource>().Play(); //objede sesi oynat
               
                skor += Random.Range(5, 15); // skoru artýr
                skorYazisi.text = "Skor: " + skor.ToString(); //skoru yazdýr

                if (skor > rekor)
                {
                    rekor = skor;
                    rekorYazisi.text = "Rekor :"+rekor.ToString();
                    PlayerPrefs.SetInt("rekor",rekor); //skoru kaydetme oyunda
                }

            }
            else if(topRenderer.color != temas.gameObject.GetComponent<SpriteRenderer>().color)
            {
                //Topun rengi ile kenar rengi eþit deðilse

                //Var olan sahneye geç aktif sahneye
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
               // SceneManager.LoadScene(0);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D temas)
    {
        //renkdegisiriciye deðince renk deðiþtri
        if (temas.gameObject.tag == "renkDegistirici")
        {
            RenkDegistir();
        }
    }


    private void RenkDegistir()
    {
        //Rastgele topa renk verir.
        int rastgele = Random.Range(1,7);

        switch(rastgele)
        {
            case 1:
                topRenderer.color = color1;
                break;
            case 2:
                topRenderer.color = color2;
                break;
            case 3:
                topRenderer.color = color3;
                break;
            case 4:
                topRenderer.color = color4;
                break;
            case 5:
                topRenderer.color = color5;
                break;
            case 6:
                topRenderer.color = color6;
                break;

        }
    }

}
