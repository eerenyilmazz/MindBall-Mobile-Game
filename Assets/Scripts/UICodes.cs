using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UICodes : MonoBehaviour
{
    public void RestartTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void StartTheNumbers()
    {
        SceneManager.LoadScene(1);
    }
    public void StartTheLetters()
    {
        SceneManager.LoadScene(12);
    }
    public void QuitTheNumbers()
    {
        Application.Quit();
    }
    public void ReturnMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
