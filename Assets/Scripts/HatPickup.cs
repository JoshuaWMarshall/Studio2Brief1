using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatPickup : MonoBehaviour
{
    public GameObject StrawHat;
    public GameObject StrawHat1;
    public GameObject StrawHatVisual;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("wIN");
            
            StrawHat.SetActive(true);
            StrawHat1.SetActive(true);

            StrawHatVisual.SetActive(true);

            Destroy(gameObject);
        }
    }

}
