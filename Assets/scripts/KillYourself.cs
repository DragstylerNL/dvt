using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillYourself : MonoBehaviour {

    private float deadTimer = 0;
	
	// Update is called once per frame
	void Update () {
        deadTimer += 1 * Time.deltaTime;
        if (deadTimer >= 1)
            Destroy(gameObject);
    }
}
