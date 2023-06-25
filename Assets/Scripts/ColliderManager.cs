using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderManager : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Ground" || (collision.gameObject.name == "OngCong"))
        {
            Debug.Log("GameOver");
        }
    }
}
