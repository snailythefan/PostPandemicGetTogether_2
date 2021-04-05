using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
	//Here you wanna declare the things that you'll use
	public AudioClip SoundToPlay;
	public float Volume;

	AudioSource audio;

	//here our boolean so the audio doesn't play twice
	public bool alreadyPlayed = false;



    // Start is called before the first frame update
    void Start()
    {
        //here you call the component of your AudioSource to be able to use it
        audio = GetComponent<AudioSource>();
    }


    //in this trigger2D, we need to tell the code we're gonna try 
    //to detect Collider2D from any other object
    void OnTriggerEnter2D(Collider2D other)
    {
    	//here we tell the code what to do,
    	//when the player enters the trigger
    	//make sure to check the player tag, bcus we don't want the 
    	//NPCs to trigger the sound
    	if (alreadyPlayed == false && other.gameObject.CompareTag("Player"))
    	{
    		audio.PlayOneShot(SoundToPlay,Volume);
    		alreadyPlayed = true;
    		Debug.Log("SoundPlayed");
    	}
    }
}
