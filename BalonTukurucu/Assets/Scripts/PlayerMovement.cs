using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static PlayerMovement Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<PlayerMovement>();
                if ( instance == null )
                {
                    var instanceContainer = new GameObject( "PlayerMovement" );
                    instance = instanceContainer.AddComponent<PlayerMovement>(); 
                }
            }
            return instance;
        }
    }

    private static PlayerMovement instance;

    Rigidbody rb;
    public float moveSpeed = 25f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Debug.Log ("moveHorizontal : " + moveHorizontal +" / moveVertical : " + moveVertical);

        rb.velocity = new Vector3(moveHorizontal*moveSpeed , rb.velocity.y , moveVertical*moveSpeed);

    }
}
