using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Giris : MonoBehaviour
{
    public GameObject[] KontrolEkrani;
    public GameObject[] GirisEkrani;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void GelenButon(int buton)
    {
        if (buton==1)
        {
            SceneManager.LoadScene("SampleScene");
        }

        if (buton==2)
        {
            for (int i = 0; i < KontrolEkrani.Length; i++)
            {
                KontrolEkrani[i].SetActive(true);
            }
            for (int i = 0; i < GirisEkrani.Length; i++)
            {
                GirisEkrani[i].SetActive(false);
            }
        }

        if (buton==3)
        {
            Application.Quit();
        }

        if (buton==4)
        {
            for (int i = 0; i < GirisEkrani.Length; i++)
            {
                GirisEkrani[i].SetActive(true);
            }
            for (int i = 0; i < KontrolEkrani.Length; i++)
            {
                KontrolEkrani[i].SetActive(false);
            }
        }
    }
}
