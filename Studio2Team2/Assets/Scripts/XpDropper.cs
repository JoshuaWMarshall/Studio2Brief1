using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XpDropper : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject xpModel;
    public int health;
    public new Transform transform;

    // Update is called once per frame
    void Update()
    {
        if(health < 0 || health == 0)
        {
            Destroy(gameObject);
            DropXp();
        }
    }

    void DropXp()
    {
        // find position of the enemy and then spawn xp at the location of enemy's death location
        Vector2 position = transform.position;
        GameObject Xp = Instantiate(xpModel, position, Quaternion.identity);
        Xp.SetActive(true);
        Destroy(Xp, 10f);
    }
}
