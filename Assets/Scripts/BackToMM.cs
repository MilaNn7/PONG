using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMM : MonoBehaviour
{
     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            LoadMainMenu();
        }
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
