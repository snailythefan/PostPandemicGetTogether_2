using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TwoWayTrigger : MonoBehaviour
{


    public TwoWaySystem system;
    														//public TwoWayText pics;


    private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "NPC")
		{
		//If you run into the NPC, Start the dialogue!
		//This takes in the dialogue that is locted on th eNPC
		system.StartDialogue(collision.GetComponent<TwoWayText>().dialogue);
		}
		//delete this if it doesn't work
		

	}


	private void OnTriggerExit2D(Collider2D collision)
	{
    	if (collision.gameObject.tag == "NPC")
    	{
           //Turns off the dialogue
			system.TurnOffDialogue();
													//delete this if it doesn't work
													//pics.characterPortrait.SetActive(false);
        	Debug.Log("on trigger exit");
    	}
}
}