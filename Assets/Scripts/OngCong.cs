using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class OngCong : MonoBehaviour
{
    public float speed = 1f;

    void Update()
    {
        if (GameManager.instance.isGameOver) return;
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Destroy")
        {
            Destroy(gameObject);
        }
    }
}
