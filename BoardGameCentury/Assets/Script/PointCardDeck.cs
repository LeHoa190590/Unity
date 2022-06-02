using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PointCardDeck : MonoBehaviour
{
    public List<PointCard> thisCard = new List<PointCard>();
    public int thisId;
    public int id;

    public int yeCube;
    public int reCube;
    public int grCube;
    public int brCube;
    public int point;
    public Sprite thisSprite;

    public Image thatImage;
    public bool cardPointBack = false;
    public static bool staticCardPointBack;
    public GameObject Slot;
    public GameObject PointSlot;
    public GameObject S1,S2,S3,S4,S5;
    public int numberOfCard;
    GameObject gameController;     
    void Start()
    {
        if(gameController == null){
            gameController = GameObject.FindGameObjectWithTag("GameController");
        }
        thisCard[0] = CardDatabase.pointList[thisId];
        numberOfCard = PointDeck.pointDeckSize;
        PointSlot = GameObject.Find("PlayerPointPanel");
    }

    // Update is called once per frame
    void Update()
    {
        Slot = GameObject.Find("PointDeckPanel");
        if(this.transform.parent != Slot.transform.parent){
            cardPointBack = false;
        }
        id = thisCard[0].id;
        yeCube = thisCard[0].yeCube;
        reCube = thisCard[0].reCube;
        grCube = thisCard[0].grCube;
        brCube = thisCard[0].brCube;
        point = thisCard[0].point;
        thisSprite = thisCard[0].thisImage;

        thatImage.sprite = thisSprite;

        staticCardPointBack = cardPointBack;
        
        if(this.tag =="Clone"){          
            if(numberOfCard>0){
            thisCard[0] = PointDeck.staDeck[numberOfCard-1];
            numberOfCard -=1;
            PointDeck.pointDeckSize -=1;
            cardPointBack = false;
            this.tag = "Untagged";
            }else{
                thisCard[0] = PointDeck.staDeck[numberOfCard];
                numberOfCard -=1;
                PointDeck.pointDeckSize -=1;
                cardPointBack = false;
                this.tag = "Untagged";
            }
        }
    }
    public void BuyCard(){
        if(TurnSystem.isYourTurn == true){
            if(yeCube > TurnSystem.currentYCube || reCube > TurnSystem.currentRCube || grCube > TurnSystem.currentGrCube || brCube > TurnSystem.currentBrCube){
                Debug.Log("not enough cube for buy this card");
            }else{
                TurnSystem.yourPoint += point;
                TurnSystem.currentYCube -= yeCube;
                TurnSystem.currentRCube -= reCube;
                TurnSystem.currentGrCube -= grCube;
                TurnSystem.currentBrCube -= brCube;
                this.transform.SetParent(PointSlot.transform);
                this.transform.localScale = Vector3.one;
                this.transform.position = new Vector3(transform.position.x, transform.position.y,0);
                this.transform.eulerAngles = new Vector3(25,0,0);
                TurnSystem.yourTotalCard += 1;
                if(TurnSystem.yourTotalCard>5){
                    GameController.yourGame = true;
                }
                gameController.GetComponent<GameController>().CheckEmpty();
                gameController.GetComponent<GameController>().EndYourTurn();
            }
        }
    }
}
