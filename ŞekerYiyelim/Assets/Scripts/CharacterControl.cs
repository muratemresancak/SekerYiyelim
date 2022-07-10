using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CharacterControl : MonoBehaviour
{
    public float HareketHizi;
    public float ZiplamaKuvveti;
    private Rigidbody fizik;
    [SerializeField]
    float _mouseX = 0.0f;
    [SerializeField] 
    float _sensitivity = 5.0f;
    public AudioClip kos;
    public AudioClip skor;
    public AudioClip can;

    void Start()
    {
        HareketHizi = 5f;
        ZiplamaKuvveti = 5f;
        fizik = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void HareketKontrolu()
    {
        transform.Translate(Input.GetAxis("Vertical") * Vector3.forward * HareketHizi * Time.deltaTime);
        transform.Translate(Input.GetAxis("Horizontal") * Vector3.right * HareketHizi * Time.deltaTime);

        if (!GetComponent<AudioSource>().isPlaying && Input.GetKey(KeyCode.W))
        {
            GetComponent<AudioSource>().PlayOneShot(kos);
        }
        if (GetComponent<AudioSource>().isPlaying && Input.GetKeyUp(KeyCode.W))
        {
            GetComponent<AudioSource>().Stop();
        }

        if (!GetComponent<AudioSource>().isPlaying && Input.GetKey(KeyCode.S))
        {
            GetComponent<AudioSource>().PlayOneShot(kos);
        }
        if (GetComponent<AudioSource>().isPlaying && Input.GetKeyUp(KeyCode.S))
        {
            GetComponent<AudioSource>().Stop();
        }

        if (!GetComponent<AudioSource>().isPlaying && Input.GetKey(KeyCode.A))
        {
            GetComponent<AudioSource>().PlayOneShot(kos);
        }
        if (GetComponent<AudioSource>().isPlaying && Input.GetKeyUp(KeyCode.A))
        {
            GetComponent<AudioSource>().Stop();
        }

        if (!GetComponent<AudioSource>().isPlaying && Input.GetKey(KeyCode.D))
        {
            GetComponent<AudioSource>().PlayOneShot(kos);
        }
        if (GetComponent<AudioSource>().isPlaying && Input.GetKeyUp(KeyCode.D))
        {
            GetComponent<AudioSource>().Stop();
        }

    }
    void ZiplamaKontrolu()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fizik.AddForce(Vector3.up * ZiplamaKuvveti, ForceMode.Impulse);
        }
    }
    void Update()
    {
        HareketKontrolu();
       
        ZiplamaKontrolu();
        _mouseX = Input.GetAxis("Mouse X");
        Vector3 rot = transform.localEulerAngles;
        rot.y += _mouseX * _sensitivity;
        transform.localEulerAngles = rot;
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag=="skr")
        {
            GetComponent<AudioSource>().PlayOneShot(skor);
        }
        if (col.gameObject.tag=="can")
        {
            GetComponent<AudioSource>().PlayOneShot(can);
        }
    }
}
