using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canSekerSil : MonoBehaviour
{
    public GameObject canseker;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }


    }

}
