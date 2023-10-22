using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public float hungerDecr = 1f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Animal")
        {
            //Destroy(gameObject);
           
            if (other.gameObject.name != "Player")
            {
                GetComponent<Hunger>().curHunger -= hungerDecr;
                //Destroy(other.gameObject);
                other.gameObject.SetActive(false);
            }
            else
            {
                Destroy(gameObject);
                PlayerController.playerLives--;
            }
        }
    }
}
