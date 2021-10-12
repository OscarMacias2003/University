using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public GameOverPantalla gameOverPantalla;
    public Transform objetivo;
    private NavMeshAgent agente;
    Animator anim;
    //Rigidbody2D rb2d;
    Player player;
    private void Awake()
    {
        agente = GetComponent<NavMeshAgent>();

    }
    void Start()
    {
        agente.updateRotation = false;
        agente.updateUpAxis = false;
        player = FindObjectOfType<Player>();
        anim = GetComponent<Animator>();
        //rb2d = GetComponent<Rigidbody2D>();
    }

    
    private void Update()
    {

        agente.SetDestination(objetivo.position);

        NavAnimationSetup();

        
        /*if (mov != Vector2.zero)
         {
             anim.SetFloat("movX", dir.x);
             anim.SetFloat("movY", dir.y);
             anim.Play("  ", -1, 0);
         }
         else
         {
             anim.speed = 1;
             anim.SetFloat("movX", dir.x);
             anim.SetFloat("movY", dir.y);
             anim.SetBool("walking", true);
         }
        */

    }

    void NavAnimationSetup()
    {
        anim.SetBool("walking", true);
        

        anim.SetFloat("movX", agente.velocity.x);

        
        
        anim.SetFloat("movY", agente.velocity.y);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            Destroy(player);
            gameOverPantalla.GameOver();
        }
    }



}
