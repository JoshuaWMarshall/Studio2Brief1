using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatPickup : MonoBehaviour
{
    public GameObject Fireball;
    public GameObject Fireball1;
    public GameObject WizardHatVisual;

    public GameObject WizardButton; 

    public GameObject UpgradeMenu;


    // Start is called before the first frame update
    void Start()
    {
        UpgradeMenu.SetActive(false);
    }

    public void Upgrade()
    {
        Time.timeScale = 0;

        UpgradeMenu.SetActive(true);

    }

    public void Wizard()
    {
        Fireball.SetActive(true);
        Fireball1.SetActive(true);
        Time.timeScale = 1;
        WizardButton.SetActive(false);
        WizardHatVisual.SetActive(true);
        UpgradeMenu.SetActive(false);
        
    }
    

}
