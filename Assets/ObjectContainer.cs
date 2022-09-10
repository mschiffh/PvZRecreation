using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectContainer : MonoBehaviour
{
    public bool isFull;
    public GameManager gameManager;
    public Image backgroundImage;

    private void Start()
    {
        gameManager = GameManager.instance;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameManager.Drag_Object != null)
        {
            if (collision.gameObject.CompareTag("DragObject")  && isFull == false)
            {
                gameManager.Current_Container = this.gameObject;
                backgroundImage.enabled = true;
            }
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        //gameManager.placeObject();
        if (gameManager.Current_Container == this.gameObject)
        {
            gameManager.Current_Container = null;
        }
        backgroundImage.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
