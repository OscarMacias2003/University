using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
    public GameObject menupausa;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Time.timeScale = 0;
            menupausa.SetActive(true);
        }
    }
    public void Menupausa()
    {
        Time.timeScale = 0;
        menupausa.SetActive(true);
    }
    public void Volver()
    {
        Time.timeScale = 1;
        menupausa.SetActive(false);
    }
    public void Gomenu()
    {
        SceneManager.LoadScene("menu");
    }
    public void Salirdeljuego()
    {
        Application.Quit();
    }
}
