using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour
{   
    private string adana;
    private void Start()
    {
        adana = SceneManager.GetActiveScene().name;
    }
    public void GameOver()
    {
        gameObject.SetActive(true);
    }

    public void RetryButton()
    {
        SceneManager.LoadScene(adana);
    }
}
