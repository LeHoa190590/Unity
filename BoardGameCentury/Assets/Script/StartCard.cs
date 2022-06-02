using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Mirror;

public class StartCard : NetworkBehaviour
{
    public GameObject Slot;
    public GameObject Its;
    public GameObject currentSlot;
    // Start is called before the first frame update
    void Start()
    {
        Slot = GameObject.Find("PlayerHand");
        Its.transform.SetParent(Slot.transform);
        Its.transform.localScale = Vector3.one;
        Its.transform.position = new Vector3(transform.position.x, transform.position.y,0);
        Its.transform.eulerAngles = new Vector3(25,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        // currentSlot = transform.parent.gameObject;
        // if(currentSlot == GameController.playSlot1 && GameController.emptySlot2 == true){              
        //     It.transform.SetParent(GameController.playSlot2.transform);
        //     It.transform.localScale = Vector3.one;
        //     It.transform.position = new Vector3(transform.position.x, transform.position.y,0);
        //     It.transform.eulerAngles = new Vector3(25,0,0);
        //     GameController.emptySlot2 = false;
        //     GameController.emptySlot1 = true;
        // }
       
    }
}
