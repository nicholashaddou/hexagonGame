using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public float movementSpeed = 500f;
    float movement = 0f;
    int temporaryScore = 0;
    public Text ScoreText;
    public Text ScoreTextEnd;

    private float timer;
    public int score = 0;

    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
        timer += Time.deltaTime;

        if (timer > 0.5f)
        {

            score += 5;

            ScoreText.text = "Points : " + score.ToString();

            timer = 0;
        }

    }

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.deltaTime * -movementSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        temporaryScore = score;
        ScoreTextEnd.text = "Your final score is: " + temporaryScore.ToString();
    }
}
