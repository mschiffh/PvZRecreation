using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectCard : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    public GameObject Object_Drag;
    public GameObject Object_Game;
    public Canvas canvas;
    private GameObject Object_Drag_Instance;
    private GameManager gameManager;

    public void OnDrag(PointerEventData eventData)
    {
        if (Object_Drag_Instance != null)
        {
            Object_Drag_Instance.transform.position = Input.mousePosition;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Object_Drag_Instance = Instantiate(Object_Drag, canvas.transform);
        Object_Drag_Instance.transform.position = Input.mousePosition;
        Object_Drag_Instance.GetComponent<ObjectDragging>().card = this;
        //Object_Drag_Instance.gameObject.tag = "DragObject";

        gameManager.Drag_Object = Object_Drag_Instance;
    }

    public void OnPointerUp(PointerEventData eventData)
    {

        gameManager.placeObject();
        gameManager.Drag_Object = null;
        Destroy(Object_Drag_Instance);
        
    }



    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;
        this.gameObject.tag = "DragObject";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
