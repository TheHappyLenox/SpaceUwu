using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverUI;

    public void OnTriggerEnter()
    {
        gameOverUI.SetActive(true);
        {


        }
    }
    
}
