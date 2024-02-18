using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private TextMeshProUGUI timerText;
    private float bossTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        timerText= GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(timerText != null)
        {
            bossTime += Time.deltaTime;
            timerText.text = bossTime.ToString();
        }

        if(bossTime >= 300f)
        {
            //put shit here
        }

        Debug.Log(bossTime);
    }
}
