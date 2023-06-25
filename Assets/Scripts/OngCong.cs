using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OngCong : MonoBehaviour
{
    public float speed = 1f;
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        
    }
}
