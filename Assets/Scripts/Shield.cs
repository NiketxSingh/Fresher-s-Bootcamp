using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    [SerializeField] private EnemyShield enemyShield;

    private void OnCollisionEnter2D(Collision2D collision) {

        if (collision.gameObject.CompareTag("Spike")) {
            enemyShield.Jump();
        }
    }
}
