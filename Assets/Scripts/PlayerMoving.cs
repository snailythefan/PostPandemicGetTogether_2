using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    public float speed = 4f;

    Animator anim;

    Rigidbody2D rb;

    Vector2 mov;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
    	//Now we detect movement with a Vector 2D
    	mov = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
    	//We make a check to be able to update the idle animations
    	if (mov != Vector2.zero)
    	{
    		anim.SetFloat("movX",mov.x);
    		anim.SetFloat("movY",mov.y);
    		anim.SetBool("walking",true);	
    	}
    	else
    	{
    		anim.SetBool("walking",false);
    	}
    	

    	//Vector3 movement = new Vector3(Input.GetAxisRaw ("Horizontal"),Input.GetAxisRaw("Vertical"), 0);

    	//transform.position = Vector3.MoveTowards(transform.position, transform.position + movement, speed*Time.deltaTime );    	
    }

    void FixedUpdate()
    {
    	//nos movemos en el FixedUpdate por las fuerzas físicas
    	rb.MovePosition(rb.position + mov * speed * Time.deltaTime);
    }
}
