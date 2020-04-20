using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{

    //To load the next level in the queue, load by 
    //  load index
    public void LoadNextLevel()
    {
        FindObjectOfType<music>().previousBuildIndex = SceneManager.GetActiveScene().buildIndex+1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

