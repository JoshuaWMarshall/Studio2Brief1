using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrawHat : MonoBehaviour
{
    public GameObject rotateAround;
    public float speed = 90;
  

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(rotateAround.transform.position, Vector3.forward, speed * Time.deltaTime);
    }
}
