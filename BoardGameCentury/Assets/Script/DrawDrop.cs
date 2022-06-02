using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawDrop : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject DropZone;
    private bool isCardDrawing = false;
    private GameObject startParent;
    private Vector2 startPosition;
    private GameObject dropZone;
    private bool isOverDropZone;

    public GameObject Hand;
    public GameObject Slot;
    public GameObject BeginSlot;
    public GameObject It;
    // Start is called before the first frame update
    void Start()
    {
        Canvas = GameObject.Find("MainCanvas");
        DropZone = GameObject.Find("PlayerCard");
        Hand = GameObject.Find("PlayerHand");
    }

    private void OnCollisionEnter2D(Collision2D collision){
        isOverDropZone = true;
        dropZone = collision.gameObject;
    }

    private void OnCollisionExit2D(Collision2D collision){
        isOverDropZone = false;
        dropZone = null;
        
    }
   // Update is called once per frame
    void Update()
    {
        
        if(isCardDrawing == true){
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            transform.SetParent(Canvas.transform, true);
        }
        
    }
    public void StartDrag()
    {
        isCardDrawing = true;
        startParent = transform.parent.gameObject;
        startPosition = transform.position;
    }

    public void EndDrag()
    {
        isCardDrawing = false;
        if(isOverDropZone){
            transform.SetParent(dropZone.transform, false);
        }
        else{
            transform.position = startPosition;
            transform.SetParent(startParent.transform, false);
        }
    }

    public void test(){
        BeginSlot = transform.parent.gameObject;
        
        if(BeginSlot != Hand){              
            It.transform.SetParent(Hand.transform);
            It.transform.localScale = Vector3.one;
            It.transform.position = new Vector3(transform.position.x, transform.position.y,0);
            It.transform.eulerAngles = new Vector3(25,0,0);
            GameController.emptySlot6 = true;
            //GameController.emptySlot1 = true;   
            Debug.Log("bing");
        }else{
            Debug.Log("nothing");
            Debug.Log(GameController.emptySlot2);
            Debug.Log(Slot);
            Debug.Log(BeginSlot);
        }            
    }

}
