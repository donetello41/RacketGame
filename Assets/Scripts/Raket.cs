using UnityEngine;
using UnityEngine.UI;

public class Raket : MonoBehaviour {

    protected float moveSpeed = 10.0f;
    protected Rigidbody2D rb;
    int score;
    public Text scoreText;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }

    public void SkorYap()
    {
        score++;
        scoreText.text = score.ToString();
    }



}
