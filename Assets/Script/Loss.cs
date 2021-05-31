using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Script
{
    public class Loss : MonoBehaviour
    {
        [SerializeField] private Text monetsText;
        [SerializeField]
        private CharacterController chplayer;

        void Start()
        {
          
            monetsText.text = " " + chplayer.Monets;
        }

        // Update is called once per frame
        void Update()
        {
            monetsText.text = " " + chplayer.Monets;
            if (PlayerPrefs.HasKey("Monets"))
            {
                if(PlayerPrefs.GetInt("Monets")< chplayer.Monets)
                {
                    PlayerPrefs.SetInt("Monets", chplayer.Monets);
                }

            }
            else if (PlayerPrefs.HasKey("Monets")==false)
            {
                PlayerPrefs.SetInt("Monets", chplayer.Monets);
            }
        }
    }
}