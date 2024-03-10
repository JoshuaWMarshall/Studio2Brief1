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

    public HatPickup hatpickup;

    public TextMeshProUGUI PlayerHpUI;

    public TextMeshProUGUI pointEarner;

    public GameObject GameMusic;


    public GameObject Gameover;

    // Start is called before the first frame update
    void Start()
    {

        playerLvl = 1;
        playerXp = 0;
        playerXpThreshold = playerLvl * 10;
        playerHp = 100;

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
         if (other.tag == "Player")
         {
             playerXp =+ 10;
             Debug.Log("Gained xp, " + playerXpThreshold + playerXp + " xp left to level up");
         }
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


        hatpickup.Upgrade(); 

    }

    public void GameOverYeah()
    {
        playerHp = 0;
        Gameover.SetActive(true);
        Time.timeScale = 0;
        GameMusic.SetActive(false);
    }
    

}
