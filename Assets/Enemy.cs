using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy: MonoBehaviour
{
    public LogicScript logic;

    Rigidbody2D rb;

    [SerializeField]
    float health = 100;
    [SerializeField]
    float speed = 1f;

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            logic.addScore(1);
            //Instantiate(redParticles, transform.position, transform.rotation);
            Destroy(gameObject);
            
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(-speed, rb.velocity.y);
    }
}
