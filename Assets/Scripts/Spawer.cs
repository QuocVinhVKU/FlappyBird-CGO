using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawer : MonoBehaviour
{
    [SerializeField] private GameObject ongCong;
    [SerializeField] private Transform posSpaw;
    [SerializeField] private float timeDelay;

    private void Start()
    {
        StartCoroutine(SpawOngCong());
    }

    IEnumerator SpawOngCong()
    {
        if (GameManager.instance.isGameReady)
        {
            if (GameManager.instance.isGameOver) StopAllCoroutines();
            float randY = Random.Range(-1.5f, 1.5f);
            GameObject objOngCong = Instantiate(ongCong, new Vector3(posSpaw.position.x, randY, posSpaw.position.z), Quaternion.identity);
            
        }
        yield return new WaitForSeconds(timeDelay);
        StartCoroutine(SpawOngCong());
    }
}
