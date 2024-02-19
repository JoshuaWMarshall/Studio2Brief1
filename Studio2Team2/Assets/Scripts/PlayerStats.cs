using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    public int playerLvl;
    public int playerXp;
    public int playerXpThreshold;
    public int playerHp;


    public TextMeshProUGUI PlayerHpUI;

    public TextMeshProUGUI pointEarner;


    public GameObject Gameover;

    // Start is called before the first frame update
    void Start()
    {

        playerLvl = 1;
        playerXp = 0;
        playerXpThreshold = playerLvl * 10;
        playerHp = 100;

    }
  
        // Update is called once per frame
    void Update()
    {
        // debug log is just to test if its working or not.
        // Debug.Log("player level = " + playerLvl + " player xp threshold = " + playerXpThreshold);

        if(playerHp <=0)
        {
            GameOverYeah();
            
            
        }

        if(playerXp >= playerXpThreshold)
        {
            LevelUp();
        }


        PlayerHpUI.text = playerHp.ToString("HP:000");

        pointEarner.text = playerXp.ToString("P:00");
       

        


    }
    void LevelUp()
    {
        playerLvl++;
        playerXpThreshold = playerLvl * 10;
        


    }

    public void GameOverYeah()
    {
        playerHp = 0;
        Gameover.SetActive(true);
        Time.timeScale = 0;
    }
    

    
}
