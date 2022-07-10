using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class doganNesne : MonoBehaviour
{
    public GameObject toplananSeker;
    int toplananSekerSayisi;
    public GameObject seker;


    public GameObject sekerCan;

    public GameObject[] kayalar;
    public GameObject can;
    int canDeger = 100;

    public GameObject btnTekrar;
    public GameObject btnAnaMenu;


    int canSayac=0;
    

    float kx;
    float kz;
    float zmn;


   


    private void Start()
    {
       
    }


    private void Update()
    {

        zmn += Time.deltaTime;
        if (zmn>=5f&&toplananSekerSayisi<6)
        {
            
            for (int i = 0; i < kayalar.Length; i++)
            {
                kx = Random.Range(5,95);
                kz = Random.Range(5,95);

                Instantiate(kayalar[i], new Vector3(kx, 1.07f, kz), Quaternion.identity);
                
            }
            zmn = 0;
           
        }
        if (zmn >= 4f && toplananSekerSayisi >= 6 && toplananSekerSayisi < 12) 
        {
            for (int i = 0; i < kayalar.Length; i++)
            {
                kx = Random.Range(5, 95);
                kz = Random.Range(5, 95);

                Instantiate(kayalar[i], new Vector3(kx, 1.07f, kz), Quaternion.identity);

            }
            zmn = 0;
        }
        if (zmn >= 3f && toplananSekerSayisi >= 12) 
        {
            for (int i = 0; i < kayalar.Length; i++)
            {
                kx = Random.Range(5, 95);
                kz = Random.Range(5, 95);

                Instantiate(kayalar[i], new Vector3(kx, 1.07f, kz), Quaternion.identity);

            }
            zmn = 0;
        }

        if (toplananSekerSayisi==30)
        {
            SceneManager.LoadScene("level2");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="rock")
        {
           
            
            canDeger -= 10;
            
            can.GetComponent<Text>().text = "Can : " + canDeger;
            if (canDeger == 50&&canSayac==0)
            {
                canSayac++;
                for (int i = 0; i < 1; i++)
                {
                    kx = Random.Range(5, 95);
                    kz = Random.Range(5, 95);

                    Instantiate(sekerCan, new Vector3(kx, 1.07f, kz), Quaternion.identity);
                }

            }
            
            if (canDeger == 10&&canSayac==1)
            {
                canSayac++;
                for (int i = 0; i < 3; i++)
                {
                    kx = Random.Range(5, 95);
                    kz = Random.Range(5, 95);

                    Instantiate(sekerCan, new Vector3(kx, 1.07f, kz), Quaternion.identity);
                }
                
            }

            if (canDeger == 0)
            {
                btnTekrar.SetActive(true);
                btnAnaMenu.SetActive(true);
                GetComponent<CharacterControl>().enabled = false;
                GetComponent<AnimatorController>().enabled = false;
                Cursor.lockState = CursorLockMode.Confined;
            }
        }
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "skr")
        {
            toplananSekerSayisi++;
            toplananSeker.GetComponent<Text>().text = "ŞEKER : " + toplananSekerSayisi;
          
        }
        if (col.gameObject.tag=="can")
        {
            canDeger += 10;
            can.GetComponent<Text>().text = "Can : " + canDeger;
        }
    }
   
}
