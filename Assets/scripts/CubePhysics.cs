using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePhysics: MonoBehaviour {

    public float Down_Up_movement = -10f;

    private float LR = 0f;
    private float Counter = 0f;
	
	// Update is called once per frame
	void Update () {

        Counter += 8 * Time.deltaTime;
        if (Counter <= 2)
            LR = 10f;
        else if (Counter > 2)
            LR = -10f;
        if(Counter > 4)
            Counter = 0;


        transform.position += new Vector3( LR* Time.deltaTime, Down_Up_movement* Time.deltaTime, 0);
    }
}
