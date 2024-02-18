using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private float spawnRate = 1f;

    [SerializeField] private GameObject enemyPrefab;

    [SerializeField] private bool canSpawn = true;



    private void Start()
    {
        StartCoroutine(Spawner());
    }

    private IEnumerator Spawner()
    {
        WaitForSeconds wait = new WaitForSeconds(spawnRate);

        while (canSpawn)
        {
            yield return wait;
            Debug.Log("oofa");
            GameObject enemyToSpawn = enemyPrefab;

            Instantiate(enemyToSpawn, transform.position, Quaternion.identity);
        }
    }
}
