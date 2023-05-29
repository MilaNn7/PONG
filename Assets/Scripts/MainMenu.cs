using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private AudioSource audioSource;

   public void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
   public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        audioSource.Play();
    }
    public void Options()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        audioSource.Play();
    }
    public void Exit()
    {
        Application.Quit();
        audioSource.Play();
    }
}
