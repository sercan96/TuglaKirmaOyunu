using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tugla : MonoBehaviour
{
   public static int toplamTuglaSayisi;  // olu�an tu�la sayisini bulabilmek i�in.
   public Sprite[] tuglaSprite;
   private int maxCarpmaSayisi;
   private int carpmaSayisi;
   private puan puanScripti;

    private void Start()
    {
        maxCarpmaSayisi = tuglaSprite.Length +1; // diziyi 0 belirlemi�sek 0+1 =1 maxCarpmaSayisi, yani 1 �arpmaya yok olacak.
        toplamTuglaSayisi++; // Oyunda ka� adet tu�la varsa ekle. �rne�in 3 tu�la olu�turduysak +3 ekler.
        puanScripti = GameObject.Find("muzik&puan").GetComponent<puan>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("top"))
        {
            puanScripti.puanArttir();
            carpmaSayisi++;
            
            if (carpmaSayisi >= maxCarpmaSayisi)
            { 
                toplamTuglaSayisi--;
                Debug.Log(toplamTuglaSayisi);
                Destroy(gameObject);
                if(toplamTuglaSayisi == 0)
                {
                    GameObject.Find("_Scripts").GetComponent<OyunKontrol>().BirSonrakiSahne();
                }
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = tuglaSprite[carpmaSayisi - 1]; // Spritelar� �al��t�rabilmemizi sa�lar.
            }
        }
    }
}