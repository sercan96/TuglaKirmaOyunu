using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muzik : MonoBehaviour
{
    static bool SahnedeMuzikVar;
    void Start()
    {
        if (!SahnedeMuzikVar)
        {
            GameObject.DontDestroyOnLoad(gameObject);
            SahnedeMuzikVar = true;
        }
        else
        {
            Destroy(gameObject);
        }
          
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
