using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPlantGame : MonoBehaviour
{

    public List<GameObject> shots;
    //public GameObject pea;
    public GameObject ProjectileInstance;
    public float fireRate;
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        //shoot();
        fireRate = 2;
        this.gameObject.tag = "Enemy";
    }

    public void shoot()
    {
        //Spawns the projectile
        //ProjectileInstance = new GameObject();
        GameObject proj = Instantiate(ProjectileInstance, this.gameObject.transform);
        //sets projectile position and location to that of the peashooter that spawned it 
        proj.transform.SetPositionAndRotation(this.gameObject.transform.position, this.gameObject.transform.rotation);
        //adds to the list of shots tracked by the plant
        shots.Add(proj);
       
    }

    // Update is called once per frame
    void Update()
    {
        //Shoots on continuous cycle
        time += Time.deltaTime;
        if(time >= fireRate)
        {
            time = 0;
            shoot();
        }
        
    }
}
