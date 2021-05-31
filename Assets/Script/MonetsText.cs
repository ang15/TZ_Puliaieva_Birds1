using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Script
{
    public class MonetsText : MonoBehaviour
    {
        [SerializeField]
        public Text text;
        [SerializeField]
        private CharacterController chplayer;




        private void Start()
        {
            text.text = " " + chplayer.Monets;

        }

        void Update()
        {

            text.text  = " " + chplayer.Monets;
          
        }
    }
}