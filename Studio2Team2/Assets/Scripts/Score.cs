using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    public XpDropper xpDropper;

    public TextMeshProUGUI pointEarner;

    public int enemyPoints;
    public void EarnPoints()
    {

        enemyPoints ++;

        pointEarner.text = enemyPoints.ToString("P:00");


    }
}
