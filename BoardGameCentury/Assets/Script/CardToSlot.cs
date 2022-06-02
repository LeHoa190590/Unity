using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class CardToSlot : NetworkBehaviour
{
    public GameObject Slot;
    public GameObject It;
    public GameObject currentSlot;
    // Start is called before the first frame update
    void Start()
    {
        Slot = GameObject.Find("PlaySlot1");
        It.transform.SetParent(Slot.transform);
        It.transform.localScale = Vector3.one;
        It.transform.position = new Vector3(transform.position.x, transform.position.y,0);
        It.transform.eulerAngles = new Vector3(25,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(GameController.emptySlot1);
        currentSlot = transform.parent.gameObject;
        if(currentSlot == GameController.playSlot1 && GameController.emptySlot2 == true){              
            It.transform.SetParent(GameController.playSlot2.transform);
            It.transform.localScale = Vector3.one;
            It.transform.position = new Vector3(transform.position.x, transform.position.y,0);
            It.transform.eulerAngles = new Vector3(25,0,0);
            GameController.emptySlot2 = false;
            GameController.emptySlot1 = true;
        }
        if(currentSlot == GameController.playSlot2 && GameController.emptySlot3 == true){              
            It.transform.SetParent(GameController.playSlot3.transform);
            It.transform.localScale = Vector3.one;
            It.transform.position = new Vector3(transform.position.x, transform.position.y,0);
            It.transform.eulerAngles = new Vector3(25,0,0);
            GameController.emptySlot3 = false;
            GameController.emptySlot2 = true;
            // Debug.Log("Bing");
            // Debug.Log(GameController.emptySlot3);
            // Debug.Log(GameController.emptySlot2);
        }
        if(currentSlot == GameController.playSlot3 && GameController.emptySlot4 == true){              
            It.transform.SetParent(GameController.playSlot4.transform);
            It.transform.localScale = Vector3.one;
            It.transform.position = new Vector3(transform.position.x, transform.position.y,0);
            It.transform.eulerAngles = new Vector3(25,0,0);
            GameController.emptySlot4 = false;
            GameController.emptySlot3 = true;
        }
        if(currentSlot == GameController.playSlot4 && GameController.emptySlot5 == true){              
            It.transform.SetParent(GameController.playSlot5.transform);
            It.transform.localScale = Vector3.one;
            It.transform.position = new Vector3(transform.position.x, transform.position.y,0);
            It.transform.eulerAngles = new Vector3(25,0,0);
            GameController.emptySlot5 = false;
            GameController.emptySlot4 = true;
        }
        if(currentSlot == GameController.playSlot5 && GameController.emptySlot6 == true){              
            It.transform.SetParent(GameController.playSlot6.transform);
            It.transform.localScale = Vector3.one;
            It.transform.position = new Vector3(transform.position.x, transform.position.y,0);
            It.transform.eulerAngles = new Vector3(25,0,0);
            GameController.emptySlot6 = false;
            GameController.emptySlot5 = true;
        }
    }
    
    
}
