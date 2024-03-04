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

    private void OnTriggerEnter(Collider Player)
    {
        // is player close enough to sign to activate? if yes then play ui text on how to jump and how the goal to the game if not then do nothing
        uiSignPrompt.SetActive(true);        
    }

    private void OnTriggerExit(Collider Player)
    {
        isInRange = false;
        if (isInRange == false)
        {
            uiSignPrompt.SetActive(false);
        }
    }
}
