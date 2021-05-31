using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Script
{
    public class Creature : MonoBehaviour
    {
        [SerializeField] protected float speed;
       
        public float Speed { get { return speed; } set { speed = value; } }


        public void Die()
        {
            //  GameController.Instance.Killed(this);

            Destroy(this.gameObject);
        }





    }
}