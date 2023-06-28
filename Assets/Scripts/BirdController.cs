using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce;

    [SerializeField] Score score;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {

        bool isTap = Input.GetKeyDown(KeyCode.Space);

        if (isTap)
        {
            // Nhay
            Jump();
        }
    }

    protected void Jump()
    {
        rb.velocity = Vector2.up * jumpForce; // Nhảy lên khi nhấn phím nhảy
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
                    score.score += 10;
                }
                else if
                    (coin.typeCoin == "Silver")
                {
                    score.score += 5;
                }
                Debug.Log("Pass");
                Debug.Log($"Score: {score.score} ");
            }
            
            Destroy(collision.gameObject);
        }
        
    }
}
