using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int playerLvl;
    public int playerXp;
    public int playerXpThreshold;
    public int playerHp;

    public GameObject Gameover;

    // Start is called before the first frame update
    void Start()
    {

        playerLvl = 1;
        playerXp = 0;
        playerXpThreshold = playerLvl * 100;
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

            if (playerHp <= 0)
            {
                playerHp = 0;
                Gameover.SetActive(true);
            }
        }
              
        
}
