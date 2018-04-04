using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public float RotationSpeed = 40;
    public GameObject player;
    public GameObject bulletPrefab;
    

    void Update () {

        float xInput = Input.GetAxisRaw("Horizontal");
        //print(xInput);

        transform.Rotate(0, 0, xInput * RotationSpeed * -1 * Time.deltaTime);

        // shoot
        if (Input.GetButtonDown("Fire1"))
        {
            Shot();
        }
    }

    void Shot()
    {

        Instantiate(bulletPrefab, player.transform.position, player.transform.rotation);
       
    }
    
}
