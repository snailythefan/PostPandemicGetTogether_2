using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//don't forget scene management!
using UnityEngine.SceneManagement;


public class SinkJumpscare : MonoBehaviour
{
    public GameObject EndCanvas;

    public GameObject dialogueCanvas;

    public GameObject Player;

	public GameObject text1;
	public GameObject text2;
	public GameObject text3;

	public GameObject JumpscareAnim;

	public AudioSource jumpscare;

	private int counter;
	private bool active = false;

	void Start()
	{
		counter = 0;
	}

	private void Update()
	{
		if (active && Input.GetKeyDown(KeyCode.Return))
        {
            if (counter == 0)
            {
            	text2.SetActive(true);
            	text1.SetActive(false);

            	++counter;
            	Debug.Log("Counter:" + counter);
            }
             else if (counter == 1)
            {
            	text3.SetActive(true);
            	text2.SetActive(false);

            	++counter;
            	Debug.Log("Counter:" + counter);
            }
            else if (counter == 2)
            {
            	text3.SetActive(false);
            	JumpscareAnim.SetActive(true);
            	jumpscare.Play();
            	++counter;
            }

            else if(counter == 3)
            {
            	SceneManager.LoadScene("EndScreen");
            	Debug.Log("EndGame");
            }
    	}
	}


   void OnTriggerEnter2D(Collider2D other)
   {
   	if (other.tag == "Player")
   	{
   		EndCanvas.SetActive(true);
   		dialogueCanvas.SetActive(false);
   		Player.SetActive(false);

   		active = true;
   	}
   	
   }
}
