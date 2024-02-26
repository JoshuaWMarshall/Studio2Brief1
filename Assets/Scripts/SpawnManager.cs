using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnManager : MonoBehaviour
{
    public float spawnRate = 2f;

    public float Rate = 50f;

    public float timeUntilSpawnRateIncreased = 5f;

    [SerializeField] private GameObject enemyPrefab;

    [SerializeField] private bool canSpawn = true;



    private void Start()
    {
        StartCoroutine(Spawner());
        StartCoroutine(ScheduleIncreases());
    }

    IEnumerator ScheduleIncreases()
    {
        yield return new WaitForSeconds(timeUntilSpawnRateIncreased);
        IncreaseSpawnRate();
        StartCoroutine(ScheduleIncreases());
    }

    void IncreaseSpawnRate()
    {
        if(spawnRate > 1)
        {
            spawnRate -= 0.5f;
            
        }
        
    }
    void Update()
    {
        
        
    }
    private IEnumerator Spawner()
    {
        //WaitForSeconds wait = ;

        while (canSpawn)
        {
            yield return new WaitForSeconds(spawnRate);
            Debug.Log("oofa");
            GameObject enemyToSpawn = enemyPrefab;

            Instantiate(enemyToSpawn, transform.position, Quaternion.identity);
        }
    }
}
