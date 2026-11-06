using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string nextSceneName = "Level2";

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
           System.Diagnostics.Debug.WriteLine("Scene transition triggered to: " + nextSceneName + " at " + DateTime.Now);
           SceneManager.LoadScene(nextSceneName);
        }
    }
}