using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Script
{
    public class WalkingMonster : Creature
    {
        [SerializeField]
        private CircleCollider2D hitCollider;
        [SerializeField] private int lives = 1;
     //   private float speed = 3.5f;
        private Vector3 dir;

        private void Start()
        {
            dir = transform.right;
        }

        private void Update()
        {
            Move();
        }
        private void Move ()
        {
            Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position + transform.up * 0.1f + transform.right * dir.x * 0.7f, 0.1f);
            if (colliders.Length > 0)
            {
                dir *= -1f;
            }
            transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, Time.deltaTime);
            

        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            CharacterController player = collision.gameObject.GetComponent<CharacterController>();

            if (player != null)
            {
                
                player.Health -= 5;

            }
            CircleCollider2D attack = collision.gameObject.GetComponentInChildren<CircleCollider2D>();
            if (player != null)
            {
                player.Monets += 4;
                lives--;
                
            }
                if (lives < 1)
            {
                Die();
            }
        }
    }
}