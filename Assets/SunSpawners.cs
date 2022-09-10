using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunSpawners : MonoBehaviour
{

    public float time = 0.0f;
    public float thresh = 10.0f;
    public GameObject sun;
    public List<GameObject> sunSpawners;

    // Start is called before the first frame update
    void Start()
    {
        //Choose with span
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= thresh)
        {
            time = 0;
            spawnSun();
        }

    }

    public void spawnSun()
    {
        int random = Random.Range(0, sunSpawners.Count);
        GameObject sunInstance = Instantiate(sun, sunSpawners[random].transform);

    }
}
