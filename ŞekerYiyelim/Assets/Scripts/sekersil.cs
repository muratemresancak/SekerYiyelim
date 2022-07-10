using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sekersil : MonoBehaviour
{
    public GameObject seker;
    float x;
    float z;




 

    void Start()
    {
        
    }

   
    void Update()
    {
       
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag=="Player")
        {
           
            Destroy(gameObject);
            x = Random.Range(10, 90);
            z = Random.Range(10, 90);
            Instantiate(seker, new Vector3(x, 1.479f, z), Quaternion.identity);

        }


    }
   
    
}
