using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce;
    public float angleRotateSpeed;
    public float jumpAngle;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        CheckGameReady();
    }
    void Update()
    {
        if (GameManager.instance.isGameOver) return;
        bool isTap = Input.GetKeyDown(KeyCode.Space);

        if (isTap)
        {
            // Nhay
            Jump();
        }
        RotateBird();
    }

    protected void Jump()
    {
        CheckGameReady();
        if (!GameManager.instance.isGamePause && GameManager.instance.isGameReady)
        {
            AudioManager.Instance.JumpAudio();
            rb.velocity = Vector2.up * jumpForce; // Nhảy lên khi nhấn phím nhảy
            transform.eulerAngles = new Vector3(0, 0, jumpAngle);
        }
        else GameManager.instance.isGameReady = true;
    }
    public void CheckGameReady()
    {
        if (!GameManager.instance.isGameReady) rb.gravityScale = 0f;
        else rb.gravityScale = 1f;
    }
    protected void RotateBird()
    {
        if (GameManager.instance.isGameReady)
        {
            transform.eulerAngles -= new Vector3(0, 0, angleRotateSpeed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            var coin = collision.gameObject.GetComponent<Coin>();
            if(coin != null)
            {
                if(coin.typeCoin == "Gold")
                {
                    GameManager.instance.AddScore(10);
                }
                else if (coin.typeCoin == "Silver")
                {
                    GameManager.instance.AddScore(5);
                }
            }
            
            Destroy(collision.gameObject);
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground" && (GameManager.instance.isGameOver == false))
        {
            AudioManager.Instance.PlayEndGameAudio();
            GameManager.instance.GameOver();
        }
    }
}
