using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Hexagon : MonoBehaviour
{
    public Rigidbody2D rb;

    public float shrinkingSpeed = 10f;
    void Start()
    {
        rb.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;
    }
    // Update is called once per frame
    void Update()
    {

        transform.localScale -= Vector3.one * shrinkingSpeed * Time.deltaTime;
        if (transform.localScale.x <= 0.05f)
        {
           Destroy(gameObject);
    
        }
      
    }
}

