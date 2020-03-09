using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBulletControl : MonoBehaviour
{
    public float Speed;
    private Rigidbody2D rb;
    private Text LivesText;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, Speed);
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.main.WorldToViewportPoint(transform.position).y < 0)
            Destroy(this.gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject.Destroy(this.gameObject);
            GameObject.Destroy(collision.gameObject);
            //GetComponent<LivesManager>().Dead = true;
            LivesText.GetComponent<LivesManager>().Lives -= 1;
            LivesText.GetComponent<LivesManager>().UpdateLives();
        }
    }
}


