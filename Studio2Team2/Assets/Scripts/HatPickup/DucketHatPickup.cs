using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DucketHatPickup : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject DucketHatVisual;
    public GameObject duckModel;
    public GameObject duckExplosionModel;

    public new Transform transform;

    // Start is called before the first frame update
    void Start()
    {

    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            

            DucketHatVisual.SetActive(true);

            Destroy(gameObject);
            StartCoroutine(DropDuck());
        }
    }
    // find position of the enemy and then spawn xp at the location of enemy's death location

    public IEnumerator DropDuck()
    {
        yield return new WaitForSeconds(3f);
        Vector2 position = transform.position;
        GameObject Duck = Instantiate(duckModel, position, Quaternion.identity);
        Duck.SetActive(true);
        Destroy(Duck, 5f);
        GameObject DuckExplosion = Instantiate(duckExplosionModel, position, Quaternion.identity);
        Destroy(DuckExplosion, 1f);

        
    }
}



