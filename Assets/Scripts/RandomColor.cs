using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomColor : MonoBehaviour
{
    public TextMeshProUGUI gameOver;

    // Update is called once per frame
    void Update()
    {
        int index = Random.Range(0, 3);
        switch (index)
        {
            case 0:
                gameOver.color = new Color32(53, 226, 242, 255);
                break;
            case 1:
                gameOver.color = new Color32(246, 223, 14, 255);
                break;
            case 2:
                gameOver.color = new Color32(140, 19, 251, 255);
                break;
            case 3:
                gameOver.color = new Color32(255, 0, 128, 255);
                break;

        }
    }
}
