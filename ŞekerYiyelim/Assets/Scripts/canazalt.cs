using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canazalt : MonoBehaviour
{
    public GameObject can;
    int canDeger=100;

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag=="Player")
        {
            can.GetComponent<Text>().text = "Can : " + (canDeger - 10);
        }
    }

}
