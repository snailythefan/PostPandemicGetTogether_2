using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//don't forget scene management!
using UnityEngine.SceneManagement;

public class StartSceneDialogue : MonoBehaviour
{
	public GameObject text1;
	public GameObject text2;
	public GameObject text3;

	private int counter;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
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
            	SceneManager.LoadScene("Level1");
            	Debug.Log("StartGame");
            }
    	}
    }	

}
