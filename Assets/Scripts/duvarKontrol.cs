using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duvarKontrol : MonoBehaviour
{
    public AudioClip duvarSesi;
    public GameObject particleEfekt;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().PlayOneShot(duvarSesi); //SES

        Vector3 pos = collision.contacts[0].point; 
        GameObject go = Instantiate(particleEfekt, pos, Quaternion.identity); // Duvar efekti.
        Destroy(go, 1f);

    }
}
