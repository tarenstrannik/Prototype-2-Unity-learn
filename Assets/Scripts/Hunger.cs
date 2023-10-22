using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hunger : MonoBehaviour
{
    private float maxHunger = 3f;
    public float curHunger= 3f;
    public Slider sliderHunger;

    private float deathDelay = 0.2f;
    void Start()
    {
        maxHunger = curHunger;
       
    }
   
    void Update()
    {
       sliderHunger.value = 1f - curHunger / maxHunger;
        if (curHunger <= 0)
        {
            StartCoroutine("Death");
           
        }
    }
    IEnumerator Death()
    {
        yield return new WaitForSeconds(deathDelay);
        PlayerController.playerScore++;
        Destroy(gameObject);
    }
}
