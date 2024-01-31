using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Slash : MonoBehaviour
{

    public GameObject slashZimbirtisi;
    public Transform SlashPoint;
    public GameObject SlashPrefab;
    public PlayerController pk;

    public float SlashRate = 1;
    public float SlashForce;

    private float time;
    private float nextTimeFire;


    void FixedUpdate()
    {
        time += Time.fixedDeltaTime;

        nextTimeFire = 1/SlashRate;

        if (time >= nextTimeFire)
        {
            if (pk.isMoving == false)
            {
                GameObject slash = SlashPool.instance.GetPooledSlash();
                if (slash != null)
                {
                    slash.transform.position = SlashPoint.position;
                    slash.SetActive(true);
                    slash.GetComponent<Rigidbody>().AddForce(SlashPoint.forward*SlashForce);
                }
                time = 0;
            }
        }
    }
}
