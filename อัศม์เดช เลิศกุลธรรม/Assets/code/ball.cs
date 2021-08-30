using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private int score;
    public Text scoreText;
    public Text winText;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        score = 0;
            SetScoreText();
        winText.text = "";
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movememt = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movememt*speed);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("item")) ;
        {
            other.gameObject.SetActive(false);

            score = score + 1;
            SetScoreText();
        }
    }
    void SetScoreText()
    {
        scoreText.text = "score:" + score.ToString();
        if(score >= 8)
        {
            winText.text = "You Win!";
        }
    }
}
