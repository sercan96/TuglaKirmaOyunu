using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class top : MonoBehaviour
{
    private GameObject pedal;
    private bool oyunBasladi = false;  // Oyun ba�lang��ta ba�lamam�� olacak.
    void Start()
    {
        pedal = GameObject.FindObjectOfType<Pedal>().gameObject;
    }

    
    void Update()
    {
        if(!oyunBasladi)  // if(!oyunBasladi)  ==) oyunBasladi=false ise bu i�lemi yapacakt�r.
        {
            transform.position = new Vector3(pedal.transform.position.x, transform.position.y, transform.position.z); //pedal�n sadece x pozisyonunu al
        }
        
        if(Input.GetMouseButtonDown(0))
        {
            oyunBasladi = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);    
        }
    }
}
