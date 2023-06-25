using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderManager : MonoBehaviour
{
    [SerializeField] private Rigidbody2D birdBody;

    void Start()
    {
        birdBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Ground" || (collision.gameObject.name == "OngCong"))
        {
            Debug.Log("GameOver");
        }
    }
}
