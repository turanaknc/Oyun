using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
    }
    public void AyarlaGit()
    {
        SceneManager.LoadScene("Ayarlar");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void MenuyeDon()
    {
        SceneManager.LoadScene("AnaMenu");
    }
    public void levelselect(int levelNumber)
    {
        SceneManager.LoadScene("Level" + levelNumber);
    }
}
