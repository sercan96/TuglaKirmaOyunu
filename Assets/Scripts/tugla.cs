using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tugla : MonoBehaviour
{
   public Sprite[] tuglaSprite;
   private int maxCarpmaSayisi;
   private int carpmaSayisi;

    private void Start()
    {
        maxCarpmaSayisi = tuglaSprite.Length +1; // diziyi 0 belirlemi�sek 0+1 =1 maxCarpmaSayisi, yani 1 �arpmaya yok olacak.
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("top"))
        {
            carpmaSayisi++;
            
            if (carpmaSayisi >= maxCarpmaSayisi)
            {
                Destroy(gameObject);
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = tuglaSprite[carpmaSayisi - 1]; // Spritelar� �al��t�rabilmemizi sa�lar.
            }
        }
    }
}