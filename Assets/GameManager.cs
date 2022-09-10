using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject Drag_Object;
    public GameObject Current_Container;
    public GameObject plantClone;
    public int sunAmt;
    TextMesh txt;
    public Text counterText;

    public static GameManager instance;

    private void Awake()
    {
        instance = this;
        sunAmt = 0;
    }

    public void placeObject()
    {
        if(Drag_Object != null && Current_Container != null)
        {
            plantClone = Instantiate(Drag_Object.GetComponent<ObjectDragging>().card.Object_Game, Current_Container.transform);
            plantClone.transform.SetPositionAndRotation(Current_Container.transform.position, Current_Container.transform.rotation); 
            Current_Container.GetComponent<ObjectContainer>().isFull = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //instance = this;   
    }

    // Update is called once per frame
    void Update()
    {
        counterText.text = sunAmt.ToString();
    }

    public void collectSun()
    {
        sunAmt += 25;
    }
}
