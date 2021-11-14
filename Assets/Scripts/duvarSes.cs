using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duvarSes : MonoBehaviour
{
    public AudioClip duvarSesi;
    public GameObject particleEfekt;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().PlayOneShot(duvarSesi);
        Vector3 pos = collision.contacts[0].point;
        GameObject go = Instantiate(particleEfekt, pos, Quaternion.identity);
        Destroy(go, 1f);

    }
}
