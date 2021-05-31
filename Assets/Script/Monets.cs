using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  
namespace Script
{
    public class Monets : MonoBehaviour
    {

        private void OnTriggerEnter2D(Collider2D collider)
        {
          
            CharacterController player = collider.gameObject.GetComponent<CharacterController>();
            if (player != null)
            {
                player.Monets += 5;
                Destroy(gameObject);
            }
        }


    }
}