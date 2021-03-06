using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tugla : MonoBehaviour
{
   public static int toplamTuglaSayisi;  // olu?an tu?la sayisini bulabilmek i?in.
   //public Sprite[] tuglaSprite;
   public Sprite spriteTugla;

   public int maxCarpmaSayisi;
   public int carpmaSayisi;
   private puan puanScripti;
   public AudioClip tuglaSes1, tuglaSes2;
   public GameObject tuglaEfekti;

    private void Start()
    {
        //maxCarpmaSayisi = tuglaSprite.Length +1; // diziyi 0 belirlemi?sek 0+1 =1 maxCarpmaSayisi, yani 1 ?arpmaya yok olacak.
        toplamTuglaSayisi++; // Oyunda ka? adet tu?la varsa ekle. ?rne?in 3 tu?la olu?turduysak +3 ekler.
        //puanScripti = GameObject.Find("muzik&puan").GetComponent<puan>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("top"))
        {
           
            //puanScripti.puanArttir();
            carpmaSayisi++;
            
            if (carpmaSayisi >= maxCarpmaSayisi)
            { 
                toplamTuglaSayisi--;
                Debug.Log(toplamTuglaSayisi);
               
                
                if(toplamTuglaSayisi == 0)
                {
                    GameObject.Find("_Scripts").GetComponent<OyunKontrol>().BirSonrakiSahne();
                }
                Vector3 pos = collision.contacts[0].point; 
                GameObject go = Instantiate(tuglaEfekti, pos, Quaternion.identity); //t?gla efektini ekledik.
                Destroy(go, 1f);

                GetComponent<AudioSource>().PlayOneShot(tuglaSes2);
                Destroy(gameObject);
            }
            else
            {
                GetComponent<AudioSource>().PlayOneShot(tuglaSes1);
                //GetComponent<SpriteRenderer>().sprite = tuglaSprite[carpmaSayisi - 1]; // Spritelar? ?al??t?rabilmemizi sa?lar.
                GetComponent<SpriteRenderer>().sprite = spriteTugla;
            }
        }
    }
}