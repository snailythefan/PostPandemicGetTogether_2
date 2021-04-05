using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

	public AudioSource BGMusic;
    

    public void ChangeBGM(AudioClip music)
    {
    	//we do this so the audio doesn't restart
    	//everytime we enter the trigger
    	if(BGMusic.clip.name == music.name)
    		return;


    	//First we tell our already existing audiotrack to stop
    	BGMusic.Stop();
    	//this means our audiotrack inside the audiosource component
    	//we're changing it to a new one
    	BGMusic.clip = music;

    	//then we tell it to play
    	BGMusic.Play();

    }
}
