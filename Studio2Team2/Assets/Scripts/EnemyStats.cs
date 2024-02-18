using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public int enemyHealth;
    public int enemyDamage;
    public float force;

    public XpDropper xpDropper;
    
    // Start is called before the first frame update
    void Start()
    {
        enemyDamage = 5;
        enemyHealth = 10;

        force = 3;
    }

   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerStats>())
        {
            collision.GetComponent<PlayerStats>().playerHp -= 5;
            Debug.Log("You took 25 damage");

            Debug.Log("push");
            if (collision.CompareTag("Player"))
            {
                Debug.Log("arghhh");
                //rb.addForce(transform.backwards * force);
                //Vector2 dir = transform.position;
                // dir = -dir.normalized;
                //GetComponent<Rigidbody2D>().AddForce( dir * force);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(enemyHealth <=0)
        {
            xpDropper.DropXp();
            Destroy(gameObject);
        }
    }
}
