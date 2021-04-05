using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMusicTrigger : MonoBehaviour
{
	//here we assign our other music track
	public AudioClip newtrack;

	//here we want to give it access to the AudioManager script
	//theAM = the AudioManager
	private AudioManager theAM;


    // Start is called before the first frame update
    void Start()
    {
        //we wanna use the audiomanager object
        theAM = FindObjectOfType<AudioManager>();
    }

    //we're gonna do an action when entering the Trigger zone
    void OnTriggerEnter2D(Collider2D other)
    {
    	//first we check if the object that walked
    	//into the zone is The Player
    	if (other.tag == "Player")
    	{
    		//then the AudioManager will
    		//change the music to our New Track

    		//but also we'll include a safe check
    		//to prevent errors
    		if (newtrack != null)
    		{
    			theAM.ChangeBGM(newtrack);
    		}
    	}
    }
}
