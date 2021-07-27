using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float offset;
    public float dist;
    int ringCount = 0;
    public void SpawnObject()
    {
        GameObject circle = ObjectPooler.SharedInstance.GetPooledObject(0);
        circle.transform.rotation = Quaternion.identity;
        circle.transform.position = (offset + dist * ringCount) * Vector3.up;
        circle.SetActive(true);

        ringCount++;
    }

    public void RestartLevel()
    {
        Debug.Log("123");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
