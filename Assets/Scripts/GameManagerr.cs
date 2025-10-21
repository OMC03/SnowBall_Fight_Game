using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject Player1;
    public GameObject Player2;
    public GameObject p1Wins;
    public GameObject p2Wins;
    public AudioSource Hurt;

    public GameObject[] p1Sticks;
    public GameObject[] p2Sticks;

    public string MainMenu;
    public int P1_Life;
    public int P2_Life;

    // Start is called before the first frame update
    void Start()
    {
        p1Wins.SetActive(false);
        p2Wins.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (P1_Life <= 0)
        {
            Player1.SetActive(false);
            p2Wins.SetActive(true);
        }

        if (P2_Life <= 0)
        {
            Player2.SetActive(false);
            p1Wins.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MenuScreen");
        }
    }

    public void HurtP1()
    {
        P1_Life -= 1;
        Hurt.Play();

        for (int i = 0; i < p1Sticks.Length; i++)
        {
            if (P1_Life > i)
            {
                p1Sticks[i].SetActive(true);
            }
            else
            {
                p1Sticks[i].SetActive(false);
            }
        }
    }

    public void HurtP2()
    {
        P2_Life -= 1;
        Hurt.Play();

        for (int i = 0; i < p1Sticks.Length; i++)
        {
            if (P2_Life > i)
            {
                p2Sticks[i].SetActive(true);
            }
            else
            {
                p2Sticks[i].SetActive(false);
            }
        }
    }
}
