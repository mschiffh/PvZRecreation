using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public List<Zombie> zombies;
    public Zombie zombie;
    public float time;
    //public float spawnInterval;
    // Start is called before the first frame update
    void Start()
    {
        spawnZombie();
    }

    void spawnZombie()
    {
        zombie = Instantiate(zombie, this.gameObject.transform);
        zombie.transform.SetPositionAndRotation(this.gameObject.transform.position, this.gameObject.transform.rotation);
        zombies.Add(zombie);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
