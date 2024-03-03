using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class BossManManager : MonoBehaviour
{

    public Transform target;

    public float speed = 1f;

    private Rigidbody2D rb;

    public float rotateSpeed = 0.05f;

    public float distanceToShoot = 5f;
    public float distanceToStop = 1f;

    public Transform firingPoint;

    public float fireRate;
    private float timeToFire;
    public float throwForce = 20f;

    public GameObject BossFireballPrefab;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        timeToFire = 0f;
    }


    private void FixedUpdate()
    {
        if (Vector2.Distance(target.position, transform.position) >= distanceToStop)
        {
            rb.velocity = transform.up * speed;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(target.position, transform.position) <= distanceToShoot)
        {
            Shoot();
        }
        if (!target)
        {
            GetTarget();
        }
        else
        {
            RotateTowardsTarget();
        }
    }

    private void Shoot()
    {
        if (timeToFire <= 0f)
        {
            GameObject fireball = Instantiate(BossFireballPrefab, firingPoint.position, firingPoint.rotation);
            fireball.GetComponent<Rigidbody2D>().AddForce(firingPoint.up * throwForce, ForceMode2D.Impulse);
            Debug.Log("Shoot");
            timeToFire = fireRate;
        }
        else
        {
            timeToFire -= Time.deltaTime;
        }
    }

    private void RotateTowardsTarget()
    {
        Vector2 targetDirection = target.position - transform.position;
        float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg - 90f;
        Quaternion q = Quaternion.Euler(new Vector3(0, 0, angle));
        transform.localRotation = Quaternion.Slerp(transform.localRotation, q, rotateSpeed);
    }

    private void GetTarget()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }
}
