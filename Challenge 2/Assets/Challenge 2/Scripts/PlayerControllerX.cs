using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float ReduceSpam = 1;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && ReduceSpam <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            ReduceSpam = 1;

        }
        if(ReduceSpam >= 0){
            ReduceSpam -= Time.deltaTime;

        }
        
    }
}
