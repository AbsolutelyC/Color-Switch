using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce;
    public SpriteRenderer sr;
    public string currentColor;
    public Color colorBlue;
    public Color colorYellow;
    public Color colorPurple;
    public Color colorRed;
    public TextMeshProUGUI countText;
    public GameObject gameOverPanel;

    private float count;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        SetRandomColor();
        gameOverPanel.SetActive(false);
    }

    private void OnTouchPress()
    {
        rb.gravityScale = 1;
        rb.bodyType = RigidbodyType2D.Dynamic;
        rb.velocity = Vector2.up * jumpForce;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "ColorChanger")
        {
            SetRandomColor();
            Destroy(collision.gameObject);
        }
        else if (collision.tag != currentColor && collision.tag != "Star")
        {
            Debug.Log("Game Over");
            gameOverPanel.SetActive(true);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else if (collision.tag == "Star")
        {
            count++;
            countText.text = count.ToString();
            Destroy(collision.gameObject);
            
        }
    }

    private void SetRandomColor()
    {
        int index = Random.Range(0, 3);
        switch (index)
        {
            case 0:
                currentColor = "Blue";
                sr.color = colorBlue;
                break;
            case 1:
                currentColor = "Yellow";
                sr.color = colorYellow;
                break;
            case 2:
                currentColor = "Purple";
                sr.color = colorPurple;
                break;
            case 3:
                currentColor = "Red";
                sr.color = colorRed;
                break;
        }
    }
}
