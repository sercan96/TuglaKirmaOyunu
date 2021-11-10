using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tugla : MonoBehaviour
{
   public static int toplamTuglaSayisi;  // oluþan tuðla sayisini bulabilmek için.
   public Sprite[] tuglaSprite;
   private int maxCarpmaSayisi;
   private int carpmaSayisi;
   private puan puanScripti;

    private void Start()
    {
        maxCarpmaSayisi = tuglaSprite.Length +1; // diziyi 0 belirlemiþsek 0+1 =1 maxCarpmaSayisi, yani 1 çarpmaya yok olacak.
        toplamTuglaSayisi++; // Oyunda kaç adet tuðla varsa ekle. Örneðin 3 tuðla oluþturduysak +3 ekler.
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
                GetComponent<SpriteRenderer>().sprite = tuglaSprite[carpmaSayisi - 1]; // Spritelarý çalýþtýrabilmemizi saðlar.
            }
        }
    }
}