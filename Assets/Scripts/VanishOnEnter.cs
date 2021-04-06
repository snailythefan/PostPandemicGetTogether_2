using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanishOnEnter : MonoBehaviour
{

	public GameObject ghost;


    void OnTriggerEnter2D(Collider2D other)
    {
    	if (other.tag == "Player")
    	{
    		ghost.SetActive(false);
    	}
    }
}
