using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XpPickUp : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<int>().playerXp();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       //if (other.tag == "Player")
       //{
           //playerXp + 10;
           //Debug.Log("Gained xp, " + playerXpThreshold + playerXp + " xp left to level up");
       //}

       if (collision.GetComponent<PlayerStats>())
       {
           collision.GetComponent<PlayerStats>().playerXp ++;
           Debug.Log("dmg enemy 5");

           Destroy(gameObject); 

       }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
