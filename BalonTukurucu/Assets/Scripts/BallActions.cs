using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Collections;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.UI;

public class BallActions : MonoBehaviour
{
    public GameObject ball;
    public int BallHealth;
    public TextMesh canGosterge;
    public GameObject newBall;
    public Transform ballPosition;
    public int maxHealth;
    private float desiredYPosition = -1f;
    private float murasakiDesiredYPosition = -0.5f;
    private Vector3 orjinalVelocity;

    void Update()
    {
        canGosterge.text = BallHealth.ToString();
        if (Input.GetKeyDown(KeyCode.Q))
        {
            TakeBallDamage(1);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Slash"))
        {
            TakeBallDamage(1);
        }
    }

    public void TakeBallDamage(int value)
    {
        if (BallHealth != 17 && BallHealth != 9 && BallHealth != 5 && BallHealth != 3 && BallHealth!=0)
        {
            BallHealth = BallHealth-value;
            canGosterge.text = BallHealth.ToString();
            if (BallHealth == 0)
            {
                ball.SetActive(false);
                BallHealth = maxHealth;
            }
        }else if (BallHealth == 17 || BallHealth == 9 || BallHealth == 5 || BallHealth == 3)
        {   
            orjinalVelocity = ball.GetComponent<Rigidbody>().velocity;
            if (BallHealth == 17)
            {
                for (int i = 0; i < 2; i++)
                {
                    GameObject newball = BallPool.instance.GetPooledKi_iro();
                    if (newball != null)
                    {
                        newball.transform.position = new Vector3(ballPosition.position.x, desiredYPosition, ballPosition.position.z);

                        Rigidbody newBallRb = newball.GetComponent<Rigidbody>();

                        newBallRb.velocity = orjinalVelocity;

                        Vector3 randomDirection = Random.onUnitSphere;
                        randomDirection.y = 0f;
                        float forceMagnitude = 5f;
                        newBallRb.AddForce(randomDirection * forceMagnitude, ForceMode.Impulse);
                        
                        newball.SetActive(true);
                    }
                }
                canGosterge.text = BallHealth.ToString();
                BallHealth = maxHealth;
                ball.SetActive(false);
            }else if (BallHealth == 9)
            {
                for (int i = 0; i < 2; i++)
                {
                    GameObject newball = BallPool.instance.GetPooledAo();
                    if (newball != null)
                    {
                        newball.transform.position = new Vector3(ballPosition.position.x, desiredYPosition, ballPosition.position.z);

                        Rigidbody newBallRb = newball.GetComponent<Rigidbody>();

                        newBallRb.velocity = orjinalVelocity;

                        Vector3 randomDirection = Random.onUnitSphere;
                        randomDirection.y = 0f;
                        float forceMagnitude = 5f;
                        newBallRb.AddForce(randomDirection * forceMagnitude, ForceMode.Impulse);
                        
                        newball.SetActive(true);
                    }
                }
                canGosterge.text = BallHealth.ToString();
                BallHealth = maxHealth;
                ball.SetActive(false);

            }else if (BallHealth == 5)
            {
                for (int i = 0; i < 2; i++)
                {
                    GameObject newball = BallPool.instance.GetPooledMidori();
                    if (newball != null)
                    {
                        newball.transform.position = new Vector3(ballPosition.position.x, desiredYPosition, ballPosition.position.z);

                        Rigidbody newBallRb = newball.GetComponent<Rigidbody>();

                        newBallRb.velocity = orjinalVelocity;

                        Vector3 randomDirection = Random.onUnitSphere;
                        randomDirection.y = 0f;
                        float forceMagnitude = 5f;
                        newBallRb.AddForce(randomDirection * forceMagnitude, ForceMode.Impulse);
                        
                        newball.SetActive(true);
                    }
                }
                BallHealth = maxHealth;
                canGosterge.text = BallHealth.ToString();
                ball.SetActive(false);
            }else if(BallHealth == 3)
            {
                for (int i = 0; i < 2; i++)
                {
                    GameObject newball = BallPool.instance.GetPooledMurasaki();
                    if (newball != null)
                    {
                        newball.transform.position = new Vector3(ballPosition.position.x, murasakiDesiredYPosition, ballPosition.position.z);

                        Rigidbody newBallRb = newball.GetComponent<Rigidbody>();

                        newBallRb.velocity = orjinalVelocity;

                        Vector3 randomDirection = Random.onUnitSphere;
                        randomDirection.y = 0f;
                        float forceMagnitude = 5f;
                        newBallRb.AddForce(randomDirection * forceMagnitude, ForceMode.Impulse);
                        
                        newball.SetActive(true);
                    }
                }
                canGosterge.text = BallHealth.ToString();
                BallHealth = maxHealth;
                ball.SetActive(false);
            }
        }
    }

}
