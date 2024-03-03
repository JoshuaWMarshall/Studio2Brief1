using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Variables

    // Determines the Movement Speed
    public float movementSpeed;

    // Keyboard Input
    public float keyHorizontal;
    public float keyVertical;

    // Player's Rigidbody
    public Rigidbody2D playerRigidBody;

    public Rigidbody2D Rb;

    


    [Header("Player Movement Keybinds")]
    [SerializeField] KeyCode upKey;
    [SerializeField] KeyCode downKey;
    [SerializeField] KeyCode leftKey;
    [SerializeField] KeyCode rightKey;


    

    
    

    #endregion

    public float knockbackForce;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();

        
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(leftKey))
        {
            keyHorizontal = -1f;
        }
        else if (Input.GetKey(rightKey))
        {
            keyHorizontal = 1f;
        }
        else
        {
            keyHorizontal = 0f;
        }

        if (Input.GetKey(upKey))
        {
            keyVertical = 1f;
        }
        else if (Input.GetKey(downKey))
        {
            keyVertical = -1f;
        }
        else { keyVertical = 0f; }


      

        

       

    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            
            Rigidbody2D Enemy = collision.GetComponent<Rigidbody2D>();
            Vector2 difference = Enemy.transform.position - transform.position;
            difference = difference.normalized * knockbackForce;
            Enemy.AddForce(difference, ForceMode2D.Impulse);
            Debug.Log("Check");

        }
    }



    void FixedUpdate()
    {
        
        playerRigidBody.velocity = new Vector2(keyHorizontal * movementSpeed, keyVertical * movementSpeed);

       
    }
}
