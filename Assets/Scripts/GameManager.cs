using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void RestartLevel()
    {
        Debug.Log("123");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}