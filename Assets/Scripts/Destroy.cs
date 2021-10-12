using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroy : MonoBehaviour
{
    public float Tiempodevida = 60;
    public string escena;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
        Tiempodevida -= Time.deltaTime;
        if (Tiempodevida <= 0)
        {
            SceneManager.LoadScene(escena);
            Destroy(this.gameObject);
        }    

    }
}
