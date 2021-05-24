using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public GameObject bullet;
    AudioSource bulletAudio;
    public AudioClip bulletSound;

    // Start is called before the first frame update
    void Start()
    {
        bulletAudio = GameObject.Find("SoundManager").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject bulletRef = Instantiate(bullet);
            bulletRef.transform.position = transform.position + new Vector3(0,0.25f,0);
            bulletAudio.clip = bulletSound;
            bulletAudio.Play();
        }
    }
}
