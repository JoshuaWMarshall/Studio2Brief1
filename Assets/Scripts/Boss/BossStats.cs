using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossStats : MonoBehaviour
{
    public int enemyHealth;

    public int MaxenemyHealth;

    public GameObject WinMenu;
    
    [SerializeField] private Slider slider;

  


    // Start is called before the first frame update
    void Start()
    {
        MaxenemyHealth = 350;
        enemyHealth = 350;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerStats>())
        {
            collision.GetComponent<PlayerStats>().playerHp -= 20;
            Debug.Log("You took 25 damage");



        }
    }
    
     
     public void UpdateHealthBar(float currentValue, float maxValue)
    {
        slider.value = currentValue / maxValue;
    }

     void Health()
    {
     
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
