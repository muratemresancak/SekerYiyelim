using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class l2skr : MonoBehaviour
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
        if (col.gameObject.tag == "Player")
        {

            Destroy(gameObject);
            x = Random.Range(2, 48);
            z = Random.Range(2, 48);
            Instantiate(seker, new Vector3(x, 1.479f, z), Quaternion.identity);

        }
        if (col.gameObject.tag == "dvr")
        {
            Destroy(gameObject);
            x = Random.Range(2, 48);
            z = Random.Range(2, 48);
            Instantiate(seker, new Vector3(x, 1.479f, z), Quaternion.identity);
        }


    }

}
