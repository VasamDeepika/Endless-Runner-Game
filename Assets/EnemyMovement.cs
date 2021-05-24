using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Rigidbody2D enemyRb;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody2D>();
      
    }

    // Update is called once per frame
    void Update()
    {
        enemyRb.velocity = new Vector2(0, -1);
    }
    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
