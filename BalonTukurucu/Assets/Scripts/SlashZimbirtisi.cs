using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlashZimbirtisi : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall") || collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Ball"))
        {
            gameObject.SetActive(false);
        }
    }
}
