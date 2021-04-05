using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCmovement : MonoBehaviour
{
	//how fast the npc will move
	public float moveSpeed;

	//we're calling its Rigidbody component to be able to move it with physics
	private Rigidbody2D rb;

	//we need something that tells us if our npc is walking or not
	public bool isWalking;

	//we need variables that tells us for how long it'll move and also stay idle.
	public float WalkTime;

	public float WaitTime;

	//and counters to keep our numbers in

	private float walkCounter;
	private float waitCounter;

	//now we need to set a value to randomize which direction our npc will take
	private int WalkDirection;
    
    void Start()
    {
    	rb = GetComponent<Rigidbody2D>();

    	//here we make sure we set the counters
    	waitCounter = WaitTime;
    	walkCounter = WalkTime;

    	//here we call our function!
    	ChooseDirection();
    }

    // Update is called once per frame
    void Update()
    {
    	//here we tell unity what we want to do when our player is/isn't walking
    	if (isWalking == true)
    	{
    		walkCounter -= Time.deltaTime;
    		
    		//We'll use a switch statement here to make a More efficient code that has certain
    		//behaviors based on what randomized number we got from the WalkDirection random range

    		//what is a switch you ask? It's a function(?) that if you give them a number, it'll decide what to do
    		//here we're telling it to use the numbers from WalkDirection:
    		switch(WalkDirection)
    		{
    			case 0:
    			//here we're using the rigidBody to move the NPC.
    			//this line here is moving the NPC up ^
    			//remember we assigned each random number a cardinal direction
    			rb.velocity = new Vector2 (0,moveSpeed);


    			//then, we use break to tell it this is where the case 0 option ends 
    			//(remember we're using 0 bcus that's part of the random numbers)
    				break;

    			case 1:

    				//this moves the NPC right
    				rb.velocity = new Vector2 (moveSpeed, 0);
    				break;

    			case 2:

    				//this line is moving the NPC down
    				rb.velocity = new Vector2 (0, -moveSpeed);

    				break;

    			case 3:
    				//this moves the NPC left
    				rb.velocity = new Vector2 (-moveSpeed, 0);

    				break;
    		}

    		//our counter is under our Switch statement
    		if(walkCounter < 0)
    		{
    			//when the counter hits zero, we'll stop walking (and restart the counter?)
    			isWalking = false;
    			waitCounter = WaitTime;
    		}
    	}
    	else
    	{
    		waitCounter -= Time.deltaTime;
    		//we wanna make sure our npc isn't moving at the moment, so we say:
    		rb.velocity = Vector2.zero;

    		if (waitCounter < 0)
    		{
    			//when the counter hits zero, we will choose a direction to walk in
    			ChooseDirection();
    		}
    	}
        
    }


    //we're making a function that chooses which direction to go
    public void ChooseDirection()
    {
    	//here we're choosing a value between 0 and 4 because we have 4 cardinal directions
    	//important to note:
    	//this range will only use 0,1,2,3 because we're using INTS. If they were FLOATS,
    	//they would use numbers like 0.50, 2.5, 3.67, etc.

    	////note: range for ints will never use the top number, so we're getting only 0.1.2.3 in this range.
    	WalkDirection = Random.Range(0,4); 

    	isWalking = true;
    	walkCounter = WalkTime;
    }
}
