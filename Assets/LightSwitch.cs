using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{

    public Light light; 

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("OnTriggerEnter " + other.gameObject.name);
        if(other.gameObject.GetComponent<Player>())
        {
            light.gameObject.SetActive(true); 


        }
        
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<Player>())
        {
            light.gameObject.SetActive(false);


        }

    }
}
