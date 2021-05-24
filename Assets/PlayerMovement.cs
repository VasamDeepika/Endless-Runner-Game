using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float playerSpeed;
    public Player localplayer;

    AudioSource playerDestroySound;
    public AudioClip playerClip;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       // localplayer = new Player();
        playerDestroySound = GameObject.Find("SoundManager").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(horizontal, vertical) * playerSpeed;
        rb.position = new Vector2(Mathf.Clamp(rb.position.x, localplayer.xMin, localplayer.xMax), Mathf.Clamp(rb.position.y, localplayer.yMin, localplayer.yMax));
    }
    [System.Serializable]
    public class Player
    {
        public float xMin, yMin, xMax, yMax;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            playerDestroySound.clip = playerClip;
            playerDestroySound.Play();
            Destroy(this.gameObject);

        }

    }
}
