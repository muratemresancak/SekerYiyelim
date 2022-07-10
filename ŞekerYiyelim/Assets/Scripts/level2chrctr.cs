using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class level2chrctr : MonoBehaviour
{
    public GameObject toplananSeker;
    int toplananSekerSayisi;
    public GameObject seker;


    public GameObject sekerCan;

    //public GameObject[] kayalar;

    public GameObject duvar;

    public GameObject can;
    int canDeger = 100;


    int canSayac = 0;


    float kx;
    float kz;
    //  float zmn;



    public GameObject oyunBitti;
    public GameObject oyunTekrar;
    public GameObject bolumTekrar;
    public GameObject anaMenü;
    public AudioClip dvar;
    private void Start()
    {

    }


    private void Update()
    {
        if (toplananSekerSayisi==20)
        {
            oyunBitti.SetActive(true);
            oyunTekrar.SetActive(true);
            bolumTekrar.SetActive(true);
            anaMenü.SetActive(true);
            GetComponent<CharacterControl>().enabled = false;
            GetComponent<Animator>().enabled = false;
            Cursor.lockState = CursorLockMode.Confined;
            GetComponent<AudioSource>().Stop();
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "dvr")
        {
            canDeger -= 10;
            GetComponent<AudioSource>().PlayOneShot(dvar);
            can.GetComponent<Text>().text = "Can : " + canDeger;
            if (canDeger == 50 && canSayac == 0)
            {
                canSayac++;
                for (int i = 0; i < 1; i++)
                {
                    kx = Random.Range(5, 45);
                    kz = Random.Range(5, 45);

                    Instantiate(sekerCan, new Vector3(kx, 1.07f, kz), Quaternion.identity);


                }

            }

            if (canDeger == 10 && canSayac == 1)
            {
                canSayac++;
                for (int i = 0; i < 1; i++)
                {
                    kx = Random.Range(5, 45);
                    kz = Random.Range(5, 45);

                    Instantiate(sekerCan, new Vector3(kx, 1.07f, kz), Quaternion.identity);
                }

            }

            if (canDeger == 0)
            {
                oyunBitti.SetActive(true);
                oyunTekrar.SetActive(true);
                bolumTekrar.SetActive(true);
                anaMenü.SetActive(true);
                GetComponent<CharacterControl>().enabled = false;
                GetComponent<Animator>().enabled = false;
                Cursor.lockState = CursorLockMode.Confined;

                GetComponent<AudioSource>().Stop();


                // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "skr")
        {
            toplananSekerSayisi++;
            toplananSeker.GetComponent<Text>().text = "ŞEKER : " + toplananSekerSayisi;
            if (duvar.transform.position.y<4.5f)
            {
                duvar.transform.position = new Vector3(duvar.transform.position.x, duvar.transform.position.y + 0.5f, duvar.transform.position.z);
            }
        }
        if (col.gameObject.tag == "can")
        {
            canDeger += 10;
            can.GetComponent<Text>().text = "Can : " + canDeger;
        }
    }

   

}