using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossStats : MonoBehaviour
{
    public int enemyHealth;

    public GameObject WinMenu;





    // Start is called before the first frame update
    void Start()
    {
        enemyHealth = 150;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerStats>())
        {
            collision.GetComponent<PlayerStats>().playerHp -= 20;
            Debug.Log("You took 25 damage");



        }
    }


    // Update is called once per frame
    void Update()
    {
        if(enemyHealth <= 0)
        {
            enemyHealth = 0;
            WinMenu.SetActive(true);
            Time.timeScale = 0;
            Destroy(gameObject);

        }
    }
}
