using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour{

    
    public float speed = 4f;
    
    Animator animacion;
    Rigidbody2D rb2d;
    Vector2 mov;
    
    // Start is called before the first frame update
    void Start()
    {
        animacion = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }
     
    // Update is called once per frame
    void Update()
    {
        mov = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
        );

       

        /*   
               Vector3 mov = new Vector3(
               Input.GetAxisRaw("Horizontal"),
               Input.GetAxisRaw("Vertical"),
               0
           );

           transform.position = Vector3.MoveTowards(
               transform.position,
               transform.position + mov,
               speed * Time.deltaTime
           );
        */
        if (mov != Vector2.zero)
        {
            animacion.SetFloat("movX", mov.x);
            animacion.SetFloat("movY", mov.y);
            animacion.SetBool("walking", true);
        }
        else
        {
            animacion.SetBool("walking", false);
        }

        

        
    }
    void FixedUpdate () {
        rb2d.MovePosition(rb2d.position + mov * speed * Time.deltaTime);
    }
    public void dead()
    {
        Destroy(gameObject);
    }


}
