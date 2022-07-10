using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level1son : MonoBehaviour
{
    
    public void gbtn(int btn)
    {
        if (btn==1)
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (btn==2)
        {
            SceneManager.LoadScene("Giris");
        }
    }
}
