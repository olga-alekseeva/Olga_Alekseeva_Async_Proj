using System.Collections;
using UnityEngine;

namespace Unit.Main
{

    public class Unit : MonoBehaviour
    {
        int health = 40;

        void Start()
        {
            ReceiveHealing();
        }
        public void ReceiveHealing()
        {
          
            StartCoroutine(Healing());
            
            
        }

        IEnumerator Healing()
        {
            while(Time.time < 3 && health < 100)
            {
                yield return new WaitForSeconds(0.5f);
                health = health + 5;
                Debug.Log(health);
            }
            if (health >= 100)
            {
                StopAllCoroutines();
            }
        }


    }
}
