using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class music : MonoBehaviour
{
    static bool AudioBegin = false;
    public int previousBuildIndex; 

    void Awake()
    {
        if (!AudioBegin)
        {
            GetComponent<AudioSource>().Play();
            DontDestroyOnLoad(gameObject);
            AudioBegin = true;
        }
    }
    void Update()
    {
        if (previousBuildIndex < SceneManager.GetActiveScene().buildIndex)
        {
            GetComponent<AudioSource>().Stop();
            AudioBegin = false;
            previousBuildIndex = previousBuildIndex+1;
        }
    }
}
