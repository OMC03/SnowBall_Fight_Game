using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowball : MonoBehaviour
{

    public float ballSpeed;
    public GameObject snowballEffect;
    private Rigidbody2D rb;
    public AudioSource Throw;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(ballSpeed * transform.localScale.x, 0f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player1")
        {
            FindObjectOfType<GameManager>().HurtP1();
        }

        if (other.tag == "Player2")
        {
            FindObjectOfType<GameManager>().HurtP2();
        }

        Instantiate(snowballEffect, transform.position, transform.rotation);
        Throw.Play();
        Destroy(gameObject);
    }

}
