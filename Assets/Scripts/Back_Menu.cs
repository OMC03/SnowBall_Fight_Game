using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back_Menu : MonoBehaviour
{
    public void Back_Start()
    {
        SceneManager.LoadScene("MenuScreen");
    }
}
