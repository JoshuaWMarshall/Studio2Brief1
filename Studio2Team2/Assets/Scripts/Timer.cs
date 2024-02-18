using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 500f;

    public TextMeshProUGUI countdownTimer;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        
        currentTime -= 1 * Time.deltaTime;
        countdownTimer.text = currentTime.ToString("00:00");

        if (currentTime <= 0)
        {
            
            currentTime = 0;
            

        }

    }
}
