using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1_Controller : MonoBehaviour
{

    public bool MoveRight = true;
    public int health = 100;
    public GameObject deathEffect;


    // Update is called once per frame
    void Update()
    {

        Vector2 position = transform.position;

        if(position.x < 1)
        {
            MoveRight = true;
        }

        if(position.x > 4)
        {
            MoveRight = false;
        }

        //move left or right based on MoveRight variable
        if (MoveRight == true)
        {
            transform.Translate(1 * Time.deltaTime, 0, 0);
            transform.localScale = new Vector2(-1, 1);
        }
        else
        {
            transform.Translate(-1 * Time.deltaTime, 0, 0);
            transform.localScale = new Vector2(1, 1);
        }

    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <=0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        
    }



}
