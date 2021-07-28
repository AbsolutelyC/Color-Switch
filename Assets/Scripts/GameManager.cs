using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float offset;
    public float dist;
    int ringCount = 0;
    int count = 0;
    public void SpawnRing()
    {
        GameObject circle = ObjectPooler.SharedInstance.GetPooledObject(0);
        circle.transform.rotation = Quaternion.identity;
        circle.transform.position = (offset + dist * ringCount) * Vector3.up;
        circle.transform.GetChild(4).gameObject.SetActive(true);
        circle.SetActive(true);

        ringCount++;
    }
    public void SpawnColorChange()
    {
        GameObject colorchange = ObjectPooler.SharedInstance.GetPooledObject(1);
        colorchange.transform.rotation = Quaternion.identity;
        colorchange.transform.position = (9 + dist * count) * Vector3.up;
        colorchange.SetActive(true);

        count++;
    }


    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
