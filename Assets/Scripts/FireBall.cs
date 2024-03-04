using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerStats>())
        {   
            collision.GetComponent<PlayerStats>().playerHp -= 15;
            

        
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
