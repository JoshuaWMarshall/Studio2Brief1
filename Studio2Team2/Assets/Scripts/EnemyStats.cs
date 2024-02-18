using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public int enemyHealth;
    public int enemyDamage;
    
    // Start is called before the first frame update
    void Start()
    {
        enemyDamage = 5;
        enemyHealth = 10;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerStats>())
        {
            other.GetComponent<PlayerStats>().playerHp -= 5;
            Debug.Log("You took 25 damage");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
