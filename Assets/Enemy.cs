using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{



    public GameObject bulletPrefab;
    public Transform gunNozzle;


    


    // Start is called before the first frame update
    void Start()
    {
        Renderer thisRenderer = GetComponent<Renderer>();
        thisRenderer.material.color = GetRandomColor(); 


    }

    Color GetRandomColor()
    {
        return new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
    }

    // Update is called once per frame
    void Update()
    {
        Ray myRay = new Ray(transform.position, transform.forward);
        RaycastHit rayHit;

        if (Physics.Raycast(myRay, out rayHit, Mathf.Infinity))
        {
            //Debug.Log("Raycast distance is : " + rayHit.distance);

            //Debug.Log("You hit : " + rayHit.transform.gameObject.name);
            if(rayHit.transform.gameObject.GetComponent<Player>())
            {
                Debug.Log("Enemy saw Player!!!");
                Shoot(); 
            }

        }
    }

    public void Shoot()
    {
        GameObject go = Instantiate(bulletPrefab, gunNozzle.position, Quaternion.identity);
        go.GetComponent<Rigidbody>().AddForce(gunNozzle.forward);
    }
}
