using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
 
    public XpDropper xpDropper;

    public TextMeshProUGUI pointEarner;

    public GameObject StartMenu;

    public GameObject PauseMenu;

    public GameObject GameMusic;

    

    public int enemyPoints;

    void Start()
    {
        Time.timeScale = 0;
        
        StartMenu.SetActive(true);
        PauseMenu.SetActive(false);
    }
    public void EarnPoints()
    {

        enemyPoints ++;

        pointEarner.text = enemyPoints.ToString("P:00");

        

    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            Time.timeScale = 0;
            PauseMenu.SetActive(true);
            GameMusic.SetActive(false);

        }
    }

    public void Load()
    {

        SceneManager.GetActiveScene();
        SceneManager.LoadScene(0);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void StartGame()
    {
        Time.timeScale = 1;
        StartMenu.SetActive(false);
        GameMusic.SetActive(true);
    }

    public void Resume()
    {
        Time.timeScale = 1;
        PauseMenu.SetActive(false);
        GameMusic.SetActive(true);
    }

}
