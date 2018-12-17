using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
<<<<<<< HEAD
    //유비는 천재야
    // Hello, World
    //유비야 전투구현
    //건방진 유비
=======


>>>>>>> parent of 729da3b... Hello, World

    public const int maxHealth = 100;

    public bool destroyOnDeath;

    //[SyncVar(hook = "OnchangeHealth")]

    public int currentHealth = maxHealth;


    public Slider healthSlider;



    //private NetworkStartPosition[] spawnPoints;

    void Start()
    {


    }

    public void TakeDamage(int amount)
    {

        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            if (destroyOnDeath)
            {
                Destroy(gameObject);
            }
            else
            {
                currentHealth = maxHealth;

                //RpcRespawn();
            }

        }
    }

    void OnchangeHealth(int health)
    {
        healthSlider.value = health;
    }
 //   [ClientRpc]
 /*
    void RpcRespawn()
    {
        if (isLocalPlayer)
        {
            Vector3 spawnPoint = Vector3.zero;
            if (spawnPoints != null && spawnPoints.Length > 0)
            {
                spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position;
            }
            transform.position = spawnPoint;
        }

    }*/
}
