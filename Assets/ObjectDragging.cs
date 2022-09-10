using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDragging : MonoBehaviour
{

    public ObjectCard card;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.tag = "DragObject";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
