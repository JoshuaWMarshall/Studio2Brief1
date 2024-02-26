using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardHatPickup : MonoBehaviour
{
    public GameObject Fireball;
    public GameObject Fireball1;
    public GameObject WizardHatVisual;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("wIN");
            
            Fireball.SetActive(true);
            Fireball1.SetActive(true);

            WizardHatVisual.SetActive(true);            

            Destroy(gameObject);
        }
    }

}
