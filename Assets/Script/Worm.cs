using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Script
{
    public class Worm : Creature
    {
        [SerializeField]
        private CircleCollider2D hitCollider;
      
        private void OnCollisionEnter2D(Collision2D collision)
        {
            CharacterController  player = collision.gameObject.GetComponent<CharacterController>();
            if (player != null)
            {
                // player.GetDamage();

                
                player.Health -= 2;
                //Vector3 hitPosition = transform.TransformPoint(hitCollider.offset);

                //    DoHit(hitPosition, hitCollider.radius, Damage);

            }

        }
    }
}