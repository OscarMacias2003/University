using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tiempodejuego : MonoBehaviour
{
    public float Tiempojuego = 60;
    public string escena1;
    public string escena2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Tiempojuego -= Time.deltaTime;
        if (Tiempojuego <= 0)
        {
            SceneManager.LoadScene(escena1, LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync(escena2);
        }
    }
}
