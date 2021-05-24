using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletMovement : MonoBehaviour
{
    Rigidbody2D bulletRb;
    AudioSource enemyDestroySound;
    public AudioClip enemyClip;
    public int score;
    ScoreManager scoreManager;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        bulletRb = GetComponent<Rigidbody2D>();
        scoreManager = FindObjectOfType<ScoreManager>();
        enemyDestroySound = GameObject.Find("SoundManager").GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        bulletRb.velocity = new Vector2(0,1);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            enemyDestroySound.clip = enemyClip;
            enemyDestroySound.Play();
            scoreManager.incrementScore();
        }

    }
}
