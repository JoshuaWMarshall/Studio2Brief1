using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 0f;
    float BossTime = 30f;

    public GameObject Gameover;

    public GameObject BossText;

    public GameObject BossDoor;
    public GameObject BossDoor1;

    public TextMeshProUGUI countdownTimer;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        BossText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        currentTime += 1 * Time.deltaTime;
        countdownTimer.text = currentTime.ToString("00:00");

        if (currentTime <= 0)
        {
            
            currentTime = 0;

        }

        if (currentTime >= BossTime)
        {
            BossText.SetActive(true);
            BossDoor.SetActive(false);
            BossDoor1.SetActive(false);


            Debug.Log("the boss has awoken");
        }
       

    }
}
