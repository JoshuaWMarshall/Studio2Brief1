using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int playerLvl;
    public int playerXp;
    public int playerXpThreshold;
    // Start is called before the first frame update
    void Start()
    {
        playerLvl = 1;
        playerXp = 0;
        playerXpThreshold = playerLvl * 100;

    }

    // Update is called once per frame
    void Update()
    {
        // debug log is just to test if its working or not.
        Debug.Log("player level = " + playerLvl + " player xp threshold = " + playerXpThreshold);
    }
}