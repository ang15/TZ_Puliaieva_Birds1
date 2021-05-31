using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Script
{
    public interface IDestructable
    {
        int Health { get; set; }
        void Die();
        void RecieveHit(float hitDamage);

    }
}