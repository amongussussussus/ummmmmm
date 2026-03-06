using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
public class ParticlePickup : MonoBehaviour
{
   [SerializeField]
   ParticleSystem itemDrop;
   [SerializeField]
   UnityEvent<int> coinCollect;
   [SerializeField]
   int itemIndex;
   float liveTime=0;
   List<ParticleSystem.Particle> exit = new List<ParticleSystem.Particle>();
   
    void Start()
    {
        itemDrop = GetComponent<ParticleSystem>();
        coinCollect.AddListener(GameObject.FindGameObjectWithTag("Logic").GetComponent<score>().AddScore);
        liveTime = Time.time;
        itemDrop.trigger.AddCollider(GameObject.FindGameObjectWithTag("Player").GetComponent<Collider2D>());
    }
    void Update()
    {
        if(Time.time - liveTime >= itemDrop.main.duration)
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    /*void OnParticleCollision(GameObject other)
    {

        if (other.CompareTag("Player"))
        {
            coinCollect.Invoke(0);
        }
    }*/
    void OnParticleTrigger()
    {
       int numExit = itemDrop.GetTriggerParticles(ParticleSystemTriggerEventType.Enter,exit);
       for (int i = 0; i < numExit; i++)
        {
            coinCollect.Invoke(itemIndex);
            Debug.Log(i);
            
        }
        
    }
}
