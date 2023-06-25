using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BỉdController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Khi nhảy => chim bay lên
        // Bay lên như thế nào? => truyền vận tốc theo chiều hướng lên trên
        // Xác định khi bấm vào màn hình

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
}
