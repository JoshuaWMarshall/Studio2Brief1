using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatThrow : MonoBehaviour
{
    public EnemyStats enemyStats;

    public GameObject bowlerhat;




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<EnemyStats>())
        {
            collision.GetComponent<EnemyStats>().enemyHealth -= 5;
            Debug.Log("dmg enemy 5");

            Destroy(gameObject); 

        }
        if (collision.GetComponent<BossStats>())
        {
            collision.GetComponent<BossStats>().enemyHealth -= 5;
            Debug.Log("dmg enemy 5");
            Destroy(gameObject);
        }

        Destroy(bowlerhat, 3f);
    }

    void update()
    {
        

    }
}
