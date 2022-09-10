using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Sun : MonoBehaviour, IPointerClickHandler
{
    public GameManager manager;
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Collected Sun");
        Destroy(this.gameObject);
        manager.collectSun();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
