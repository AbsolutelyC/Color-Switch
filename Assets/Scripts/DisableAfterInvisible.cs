using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableAfterInvisible : MonoBehaviour
{
    public Camera cam;
    private void Update()
    {
        float dist = cam.transform.position.y - gameObject.transform.position.y;
        if (dist >= 12)
        {
            gameObject.SetActive(false);
        }
    }
}
