using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Script
{
    public class ObStacle : Creature
    {
        [SerializeField]
        private CircleCollider2D hitCollider;
        private void OnCollisionEnter2D(Collision2D collision)
        {
            CharacterController player = collision.gameObject.GetComponent<CharacterController>();
            if (player != null)
            {
                player.Health -= 3;
                //Vector3 hitPosition = transform.TransformPoint(hitCollider.offset);

                //DoHit(hitPosition, hitCollider.radius, Damage);
                // player.GetDamage();
            }
        
        }
    }
}