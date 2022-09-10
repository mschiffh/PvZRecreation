using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sunflower : MonoBehaviour
{
    public float time = 0.0f;
    public float thresh = 10.0f;
    public GameObject sun;
    // Start is called before the first frame update
    void Start()
    {
        
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
        GameObject sunInstance = Instantiate(sun, this.gameObject.transform);

    }
}
