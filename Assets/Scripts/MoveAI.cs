
using UnityEngine;
using UnityEngine.UI;

public class MoveAI : Raket {

    public Transform top;
    int score;
    public float refVal = 2.0f;

    // Update is called once per frame
    void FixedUpdate () {
        float RaketTopFark = Mathf.Abs(top.position.y - transform.position.y);

        if (RaketTopFark > refVal)
        {
            if (top.position.y > transform.position.y)
            {
                rb.velocity = new Vector2(0, 1) * moveSpeed;
            }

            if (top.position.y < transform.position.y)
            {
                rb.velocity = new Vector2(0, -1) * moveSpeed;
            }
        }
    }

}
