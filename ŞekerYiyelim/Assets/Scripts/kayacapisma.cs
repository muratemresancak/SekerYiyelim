using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kayacapisma : MonoBehaviour
{
    public AudioClip carp;
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            if (!GetComponent<AudioSource>().isPlaying)
            {
                
                GetComponent<AudioSource>().PlayOneShot(carp);
                StartCoroutine(sil());
            }
        }
    }

    IEnumerator sil()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
