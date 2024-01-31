using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody RgbBullet;
    [SerializeField] public int NumOfBounces = 3;

    private Vector3 lastVelocity;
    private int curBounces = 0;

    void LateUpdate()
    {
        lastVelocity = RgbBullet.velocity;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall") || collision.gameObject.CompareTag("Player"))
        {
            if (curBounces >= NumOfBounces) return;

            Vector3 reflection = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);
            reflection.y = 0;
            RgbBullet.velocity = reflection * Mathf.Max(lastVelocity.magnitude, 0);

            curBounces++;
        }
    }
    
}
