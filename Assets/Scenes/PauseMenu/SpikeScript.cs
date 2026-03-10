using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpikeScript : MonoBehaviour
{
    //Do something when the player hit the obstacle
    [SerializeField,Tooltip("The effect that play when the player dies")]
    GameObject deathEffect;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") == true)
        {
            Debug.Log("Obstacle hit");
            killPlayer(GameObject.FindGameObjectWithTag("Player"), deathEffect);
        }
    }
    void killPlayer(GameObject player, GameObject deathEffect)
    {
        Instantiate(deathEffect,player.transform.position,player.transform.rotation);
        Destroy(player);
    }
}
