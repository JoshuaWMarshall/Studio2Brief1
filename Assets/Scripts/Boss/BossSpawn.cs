using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawn : MonoBehaviour
{
    #region
    public GameObject SpawnManager1;
    public GameObject SpawnManager2;
    public GameObject SpawnManager3;
    public GameObject SpawnManager4;
    public GameObject SpawnManager5;
    public GameObject SpawnManager6;
    public GameObject SpawnManager7;
    public GameObject SpawnManager8;

    public GameObject BossMenu;
#endregion
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SpawnManager1.SetActive(false);
        SpawnManager2.SetActive(false);
        SpawnManager3.SetActive(false);
        SpawnManager4.SetActive(false);
        SpawnManager5.SetActive(false);
        SpawnManager6.SetActive(false);
        SpawnManager7.SetActive(false);
        SpawnManager8.SetActive(false);

        BossIsSpawning();
        
    }

    void BossIsSpawning()
    {
        BossMenu.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
