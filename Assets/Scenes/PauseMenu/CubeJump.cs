using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class CubeJump : MonoBehaviour
{
    /*This code's sole purpose is to makes the player jump by set the player's linear and angular velocity
    to a preset value and play a sound effect accordingly*/
    [SerializeField]
    Rigidbody2D cube;
    [SerializeField]
    float force;
    [SerializeField]
    float angularVelocity;
    [SerializeField]
    AudioClip jumpSFX;
    SoundFX scriptSFX;//the SFX class
    InputAction jumpInput;
    bool notAirborne = false;//this ensure the player did not jump mid air
    
    void Start()
    {
        jumpInput = InputSystem.actions.FindAction("Jump");
        scriptSFX = GameObject.FindGameObjectWithTag("SoundFX").GetComponent<SoundFX>();
    }

    // Update is called once per frame
    
    void Update()
    {
        if(jumpInput.IsPressed())
        {
            jump();
        }
    }
    void OnCollisionEnter2D()
    {
        notAirborne = true;
        Debug.Log("Enable Jump");
    }
    void jump()
    {
        if (notAirborne == true)
        {
            Debug.Log("Jump");
            cube.linearVelocity = Vector2.up * force;
            cube.angularVelocity = angularVelocity;
            scriptSFX.playSFX(jumpSFX,transform,1f);
            notAirborne=false;
        }
    }
    /*void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle") == true)
        {
            Destroy(cube);
        }
    }*/
}
