using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlerHat : MonoBehaviour
{
    public GameObject HatPrefab;
    public Transform ThrowPoint;
    public float throwForce = 20f;

    Vector2 mousePosition;
    public Rigidbody2D rb;

    public Transform player;



    // Start is called before the first frame update
    public void Fire()
    {
        GameObject hat = Instantiate(HatPrefab, ThrowPoint.position, ThrowPoint.rotation);  
        hat.GetComponent<Rigidbody2D>().AddForce(ThrowPoint.up * throwForce, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        transform.position = player.position;

    }

    private void FixedUpdate()
    {

        Vector2 aimDirection = mousePosition - rb.position;
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = aimAngle;

        
    }
}
