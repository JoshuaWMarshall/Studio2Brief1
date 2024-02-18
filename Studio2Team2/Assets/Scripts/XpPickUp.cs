using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XpPickUp : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        // GetComponent<int>().playerXp();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       // if (other.tag == "Player")
       // {
       //     playerXp + 10;
       //     Debug.Log("Gained xp, " + playerXpThreshold + playerXp + " xp left to level up");
       // }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
