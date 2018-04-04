using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour {

    public Transform prefab;
    public float RangeXspawn = 10;
    public float SpawnThreshold = 1F;

    private float SpawnTime = 0f;
    private float SpawnTimer = 0F;
    private float TempA = 0f;

    // Update is called once per frame
    void Update () {

        SpawnTimer += Time.deltaTime;
        SpawnTime += Time.deltaTime;
        if (SpawnTime >= 2)
        {
            SpawnThreshold -= 0.02f;
            SpawnTime = 0;
        }
        if (SpawnTimer>=SpawnThreshold)
        {
            SpawnCube();
        }
        
    }

    private void SpawnCube()
    {
        Instantiate(prefab, new Vector3(Rnd(), 10.0F, 0.0F), Quaternion.identity);

        SpawnTimer = 0;
    }

    private float Rnd()
    {
        TempA = Random.value;
        TempA *= RangeXspawn;
        TempA -= (RangeXspawn/2);
        return TempA;
    }

    public void DecreaseTime()
    {
        SpawnThreshold -= 0.05f;
    }
}
