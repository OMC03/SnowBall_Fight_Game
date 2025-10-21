using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string level1;
    public string level2;
    public string controls;

    public void Level_One()
    {
        SceneManager.LoadScene(level1);
    }

    public void Level_Two()
    {
        SceneManager.LoadScene(level2);
    }

    public void Controls_Menu()
    {
        SceneManager.LoadScene(controls);
    }

    public void Quit_Game()
    {
        Application.Quit();
    }
}
