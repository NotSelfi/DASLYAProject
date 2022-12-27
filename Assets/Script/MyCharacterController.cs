using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacterController : MonoBehaviour
{
    //Lesly
    public Transform tr;
    public Rigidbody rb;
    public HealthBar healthBar;
    
    public float jumpSpeed = 5000f;
    public float walkSpeed;
    public float rotationSpeed;
    public int maxHealth = 100;
    public int currentHealth; 
    private bool wantToJump;
    

    
    //public Quarterion rotation;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
   
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space)){
            wantToJump = true;
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            TakeDamage(10);
        }
       
    }

    private void FixedUpdate()
    {
        
        if (wantToJump)
        {
            wantToJump = false;
            rb.AddForce(0f, jumpSpeed * Time.deltaTime, 0f);
        }
        
        if (Input.GetKey(KeyCode.Z)){
            tr.position += tr.rotation * Vector3.forward * ( walkSpeed * 1000.0f* Time.deltaTime)/3600f;
        }
        
        if (Input.GetKey(KeyCode.S)){
            tr.position += tr.rotation * Vector3.back * ( walkSpeed * 1000.0f* Time.deltaTime)/3600f;
        }
        
        if (Input.GetKey(KeyCode.Q)){
            tr.Rotate(Vector3.up,-rotationSpeed * Time.deltaTime) ;
        }
        
        if (Input.GetKey(KeyCode.D)){
            tr.Rotate(Vector3.up,rotationSpeed * Time.deltaTime) ;
        } 
       
    }
    
    

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
    //
}

