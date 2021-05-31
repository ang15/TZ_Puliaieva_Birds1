using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Script
{
    public class Health : MonoBehaviour
    {
        public bool PauseGame;
        [SerializeField]
        public Slider HealthBar;
          [SerializeField]
        private GameObject LoseGameObject;
        [SerializeField]
        private CharacterController chplayer;

        [SerializeField]
        public int health;


        private void Start()
        {
            health = chplayer.Health;
            HealthBar.value = health;
            
        }

        void Update()
        {
          
            health = chplayer.Health; 
            HealthBar.value = health;
            if (health <1)
            {
               LoseGameObject.SetActive(true);
                Time.timeScale = 0f;
                PauseGame = true;
            }
        }

    }

}