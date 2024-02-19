using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public int enemyHealth;
    public int enemyDamage;
    public float force;

    public XpDropper xpDropper;

    public Score score;

    public int EnemyKills;
    
    // Start is called before the first frame update
    void Start()
    {
        enemyDamage = 5;
        enemyHealth = 10;

        EnemyKills = 0;

        force = 3;
    }

   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerStats>())
        {
            collision.GetComponent<PlayerStats>().playerHp -= 5;
            Debug.Log("You took 25 damage");

            
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(enemyHealth <=0)
        {
           xpDropper.DropXp();

            EnemyKills++;

            Destroy(gameObject);
        }
    }
}
