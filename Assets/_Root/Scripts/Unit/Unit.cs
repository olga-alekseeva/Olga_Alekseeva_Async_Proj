using System.Collections;
using UnityEngine;


public class Unit : MonoBehaviour
{
    public int health = 40;
    public int maxHealth = 100;
    public int bonusHealth = 5;
    int endTime = 3;
    float delayTime = 0.5f;
    private Coroutine _coroutine;
    private void Awake()
    {
        _coroutine = null;
    }
    public void ReceiveHealing()
    {
        if (_coroutine == null)
        {
            _coroutine = StartCoroutine(Healing());
        }
    }

    IEnumerator Healing()
    {
        float passedTime = 0;
        while (passedTime < endTime)
        {
            yield return new WaitForSeconds(delayTime);
            passedTime += delayTime;
            health += bonusHealth;
            Debug.Log(health);
            if (health > maxHealth)
            {
                health = maxHealth;
                break;
            }
        }
        _coroutine = null;
    }
}





