using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawnLocation : MonoBehaviour
{
    public GameObject enemyPrefab;
    float time = 0;
    PlayerMovement player;
    //Player screenDimensions;
    // Start is called before the first frame update
    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerMovement>();
        //screenDimensions = new Player();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 2.0f && player!=null)
        {
            float value = Random.Range(-3.0f, 3.0f);
            GameObject enemyRef = Instantiate(enemyPrefab);
            enemyRef.transform.position = new Vector3(value, 6.0f, 0);
            time = 0;
        }
    }
}
