using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class BulletMovement : MonoBehaviour
{

    public float speed = 20;
    public GameObject Prefab;
    public GameObject Partice;
    public AudioClip cl;

    private float destroy = 0;

    void Update()
    {

        transform.Translate(Vector3.up * Time.deltaTime * speed, Space.Self);

        destroy += 1 * Time.deltaTime;
        if (destroy >= 2)
            Destroy(gameObject);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cube"))
        {
            Destroy(other.gameObject);
            Instantiate(Partice, this.transform.position, this.transform.rotation);
            addScore();
            AudioSource.PlayClipAtPoint(cl, this.transform.position);
        }
    }

    public void addScore()
    {
        Instantiate(Prefab);
        //GetComponent<_GameManager>().score();
    }


}

