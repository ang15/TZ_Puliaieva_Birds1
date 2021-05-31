using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Script
{

    public class BestResult : MonoBehaviour
    {
        [SerializeField]
        public Text input;

        private void Start()
        {
            if (PlayerPrefs.HasKey("Monets"))
            {
                
                input.text = " " + PlayerPrefs.GetInt("Monets");

            }
            else
            {
                input.text = " " + 0;
            }

        }

        private void Update()
        {

            if (PlayerPrefs.HasKey("Monets"))
            {
               input.text = " " + PlayerPrefs.GetInt("Monets");
            }
            else
            {
                input.text = " " + 0;
            }
        }

    }
}