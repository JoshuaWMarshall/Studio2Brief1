using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XpPickUp : MonoBehaviour
{




    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (other.tag == "Player")
        //{
        //playerXp + 10;
        //Debug.Log("Gained xp, " + playerXpThreshold + playerXp + " xp left to level up");
        //}

        if (collision.GetComponent<PlayerStats>())
        {
            collision.GetComponent<PlayerStats>().playerXp++;
            Debug.Log("dmg enemy 5");



            Destroy(gameObject);

        }
    }
}
