using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public float Speed = 2.5f;
    public SpriteRenderer projectileTest;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(projectileTest.flipX);
        transform.position += transform.right * Time.deltaTime * Speed;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
