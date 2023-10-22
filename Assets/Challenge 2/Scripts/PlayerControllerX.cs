using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float actionDelay = 1.0f;
    private float curActionDelay;
    // Update is called once per frame
    private void Start()
    {
        curActionDelay = 0f;
    }
    void Update()
    {
        curActionDelay -= Time.deltaTime;
        if (curActionDelay < 0f)
        {
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                curActionDelay = actionDelay;
            }
        }
    }
}
