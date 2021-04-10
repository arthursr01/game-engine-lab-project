using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{

    public GameObject player;
    public float speed = 5;
    public Rigidbody2D rb;
    public int damage = 40;

    // Start is called before the first frame update
    void Start()
    {
        
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Destroy(gameObject);
        Debug.Log(hitInfo.name);
        Enemy1_Controller enemy = hitInfo.GetComponent<Enemy1_Controller>();
        if(enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
