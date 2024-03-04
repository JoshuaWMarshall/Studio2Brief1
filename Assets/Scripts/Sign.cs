using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sign : MonoBehaviour
{
       public GameObject uiSignPrompt;
    public bool isInRange;
    // Start is called before the first frame update
    void Start()
    {
        uiSignPrompt.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // is player close enough to sign to activate? if yes then play ui text 
    if (other.tag == "Player")    {        uiSignPrompt.SetActive(true);     }
              
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            isInRange = false;
            if (isInRange == false)
            {
                uiSignPrompt.SetActive(false);
            }

        }
        
    }

}
