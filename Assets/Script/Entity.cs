using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Script
{
    public class Entity : MonoBehaviour
    {
        public virtual void GetDamage()
        {

        }
        public virtual void Die()
        {
            Destroy(this.gameObject);
        }
    }
}