using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    public string next;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            NextScene(next);
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void NextScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
