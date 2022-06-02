using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointToSlot : MonoBehaviour
{
    public GameObject Slot;
    public GameObject It;
    public GameObject currentSlot;
    // Start is called before the first frame update
    void Start()
    {
        Slot = GameObject.Find("PointSlot1");
        It.transform.SetParent(Slot.transform);
        It.transform.localScale = Vector3.one;
        It.transform.position = new Vector3(transform.position.x, transform.position.y,0);
        It.transform.eulerAngles = new Vector3(25,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Slot.transform.childCount);
        currentSlot = transform.parent.gameObject;
        if(currentSlot == GameController.PointSlot1 && GameController.emptyPoint2 == true){              
            It.transform.SetParent(GameController.PointSlot2.transform);
            It.transform.localScale = Vector3.one;
            It.transform.position = new Vector3(transform.position.x, transform.position.y,0);
            It.transform.eulerAngles = new Vector3(25,0,0);
            GameController.emptyPoint2 = false;
            GameController.emptyPoint1 = true;
        }
        if(currentSlot == GameController.PointSlot2 && GameController.emptyPoint3 == true){              
            It.transform.SetParent(GameController.PointSlot3.transform);
            It.transform.localScale = Vector3.one;
            It.transform.position = new Vector3(transform.position.x, transform.position.y,0);
            It.transform.eulerAngles = new Vector3(25,0,0);
            GameController.emptyPoint3 = false;
            GameController.emptyPoint2 = true;
        }
        if(currentSlot == GameController.PointSlot3 && GameController.emptyPoint4 == true){              
            It.transform.SetParent(GameController.PointSlot4.transform);
            It.transform.localScale = Vector3.one;
            It.transform.position = new Vector3(transform.position.x, transform.position.y,0);
            It.transform.eulerAngles = new Vector3(25,0,0);
            GameController.emptyPoint4 = false;
            GameController.emptyPoint3 = true;
        }
        if(currentSlot == GameController.PointSlot4 && GameController.emptyPoint5 == true){              
            It.transform.SetParent(GameController.PointSlot5.transform);
            It.transform.localScale = Vector3.one;
            It.transform.position = new Vector3(transform.position.x, transform.position.y,0);
            It.transform.eulerAngles = new Vector3(25,0,0);
            GameController.emptyPoint5 = false;
            GameController.emptyPoint4 = true;
        }
    }
}
