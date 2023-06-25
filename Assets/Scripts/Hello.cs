using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello : MonoBehaviour
{
    private void OnEnable()
    {
        Debug.Log("Ena");
    }
    private void Awake()
    {
        Debug.Log("Awake");
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDisable()
    {
        Debug.Log("Dis");
    }
    private void OnDestroy()
    {
        Debug.Log("Des");
    }
}
