using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelTrigger : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerEnter()
    {
        gameManager.completeLevel();
    }
}
