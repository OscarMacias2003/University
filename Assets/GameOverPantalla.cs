using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverPantalla : MonoBehaviour
{
    public GameObject gameOverPantalla;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverPantalla.SetActive(true);
        
    }
}
