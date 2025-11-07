using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyShield : MonoBehaviour {
    private GameObject player;
    private Vector3 playerPosition;
    [SerializeField] private float enemySpeed = 2f;
    private Rigidbody2D rb_enemy;
    private float enemyJumpSpeed = 5f;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
        rb_enemy = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
        playerPosition = player.transform.position;
        transform.position += new Vector3(playerPosition.x - transform.position.x, 0, 0).normalized * enemySpeed * Time.deltaTime;

    }


    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.CompareTag("Player")) {
            Time.timeScale = 0f;
            Debug.Log("Game Over");
        }

        if (collision.gameObject.CompareTag("Spike")) {
            Jump();
        }
    }

    public void Jump() {
        rb_enemy.velocity = new Vector2(rb_enemy.velocity.x, enemyJumpSpeed);
    }
}