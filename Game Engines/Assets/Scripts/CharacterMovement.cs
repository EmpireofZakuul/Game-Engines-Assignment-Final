using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterMovement : MonoBehaviour
{
     public grey ascript;
     public GameObject characterDie;
    [Header("Player Movement")]
    public static Vector3 positionOfPlayer;//stores the information about the character 

    public CharacterController playerController;
    public float characterSpeed = 12f;
    public float gravity = -9.81f;
    Vector3 velocity;

    public Transform checkGround;
    public float distanceToGround = 0.4f;
    public LayerMask ground;
    public bool grounded;

    public float jumpHeight = 3f;
    [Header("Player Health")]
    public int maxHealth = 100;
    public int health;
    public PlayerHealthBar PlayerHealthBar;

    

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        PlayerHealthBar.setMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        grounded = Physics.CheckSphere(checkGround.position, distanceToGround, ground);

        if (grounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        playerController.Move(move * characterSpeed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && grounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        velocity.y += gravity * Time.deltaTime;
        playerController.Move(velocity * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Z))
        {
            TakeDamageCharacter(15);
        }
        if(health <=20)
        {
          ascript.enabled = true;
        }
        if(health <= 0)
        {
            //Destroy(characterDie,2f);
            SceneManager.LoadScene("Lose");
        }    
    }

     public void TakeDamageCharacter(int damage)
    {

        health -= damage;
        PlayerHealthBar.SetHealth(health);
    }
}
