using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue2 : MonoBehaviour
{
    public GameObject Apunte;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Apunte.SetActive(true);

        }

    }

    private void OnTriggerExit2D(Collider2D coll)
    {
        if(coll.CompareTag("Player"))
        {
            Apunte.SetActive(false);
        }
    }

    
        
 
}
