using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XpDropper : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject xpModel;
    
    public new Transform transform;

    public int enemyHealth;
    // Update is called once per frame
    void Update()
    {
        
    }

    public void DropXp()
    {
        // find position of the enemy and then spawn xp at the location of enemy's death location
        Vector2 position = transform.position;
        GameObject Xp = Instantiate(xpModel, position, Quaternion.identity);
        Xp.SetActive(true);
        Destroy(Xp, 10f);
    }
}
