using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menuu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EscenaJuego()
    {
        SceneManager.LoadScene("Tutorial salon de clases");
    }
    public void Salir()
    {
        Application.Quit();
    }
}
