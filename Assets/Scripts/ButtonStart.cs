using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonStart : MonoBehaviour
{

    public void PlayGame (string sceneName)
    {
    	SceneManager.LoadScene(sceneName);
    }
}
