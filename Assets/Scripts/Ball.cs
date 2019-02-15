using UnityEngine;

public class Ball : MonoBehaviour {

    Rigidbody2D rb;
    float moveSpeed = 15.0f;
    public Raket solRaket, sagRaket;
    AudioSource audioSource;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(moveSpeed, 12);
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource.Play();
        if (collision.transform.name == "SolDuvar")
            sagRaket.SkorYap();
        if (collision.transform.name == "SagDuvar")
            solRaket.SkorYap();
        if (collision.transform.name == "SolRaket")
            DonusYonuHesapla(1, collision);
        if (collision.transform.name == "SagRaket")
            DonusYonuHesapla(-1, collision);
    }

    private void DonusYonuHesapla(int v, Collision2D collision)
    {
        float pay = transform.position.y - collision.transform.position.y;
        float y = pay / collision.collider.bounds.size.y;
        rb.velocity = new Vector2(v, y) * moveSpeed;
    }
}
