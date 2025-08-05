using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public GameObject gameOver;
    public AudioSource scream;
    public bool isAlive = true;

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void death() {
        gameOver.SetActive(true);
        isAlive = false;
        scream.Play();
    }
}
