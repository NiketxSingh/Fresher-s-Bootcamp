using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyBasic : MonoBehaviour
{
    private GameObject player;
    private Vector3 playerPosition;
    [SerializeField] private float enemySpeed = 2f;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void FixedUpdate() {
        playerPosition = player.transform.position;
        transform.position += new Vector3(playerPosition.x - transform.position.x, 0, 0).normalized * enemySpeed * Time.deltaTime;

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Time.timeScale = 0f;
            Debug.Log("Game Over");
        }
    }
}