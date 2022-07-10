using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class l2son : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void bbuton(int btn)
    {
        if (btn == 1)
        {
            SceneManager.LoadScene("SampleScene");
            Debug.Log("1");
        }
        if (btn == 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Debug.Log("2");
        }
        if (btn == 3)
        {
            SceneManager.LoadScene("Giris");
            Debug.Log("3");
        }
    }
}
