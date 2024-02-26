using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrawHat : MonoBehaviour
{
    public GameObject rotateAround;
    public float speed = 90;
  

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(rotateAround.transform.position, Vector3.forward, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<EnemyStats>())
        {
            collision.GetComponent<EnemyStats>().enemyHealth -= 5;
            Debug.Log("dmg enemy 5");

            
        }
        if (collision.GetComponent<BossStats>())
        {
             collision.GetComponent<BossStats>().enemyHealth -= 5;
            Debug.Log("dmg enemy 5");
        }
           


        
    }
   
 

}
