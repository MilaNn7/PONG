using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public Rigidbody2D rb;
    public float speed = 100.0f;
    private AudioSource audioSource;
    // Start is called before the first frame update
    private void Start()
    {
        ResetPosition();
        Sila();
        audioSource = GetComponent<AudioSource>();
    }
    public void ResetPosition()
    {
        rb.position = Vector2.zero;
        rb.velocity = Vector2.zero;

    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void Sila()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);

        Vector2 direction = new Vector2(x, y);
        rb.AddForce(direction * speed);
    }
    public void AddForce(Vector2 force)
    {
        rb.AddForce(force);
        audioSource.Play();
    }
 
}
