using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlayCard : MonoBehaviour
{
    public List<Card> thisCard = new List<Card>();
    public int thisId;

    public int id;
    public int yeCube;
    public int reCube;
    public int grCube;
    public int brCube;
    public int upGrade;
    public Sprite thisSprite;

    public Image thatImage;

    public bool cardBack = false;
    public static bool staticCardBack;    

    public GameObject Slot, Used, Player,check;
    public int numberOfCardInDeck, numberCard;
    GameObject gameController;
    void Start()
    {
        if(gameController == null){
            gameController = GameObject.FindGameObjectWithTag("GameController");
        }
        thisCard[0] = CardDatabase.cardList[thisId];
        numberOfCardInDeck = PlayDeck.deckSize;
        numberCard = PlayDeck.starSize;
    }

    // Update is called once per frame
    void Update()
    {
        Player = GameObject.Find("PlayerHand");
        Used = GameObject.Find("PlayerCard");
        Slot = GameObject.Find("PlayDeckPanel");
        check = this.transform.parent.gameObject;
        if(check == Slot){
            cardBack = true;
        }

        id = thisCard[0].id;
        yeCube = thisCard[0].yeCube;
        reCube = thisCard[0].reCube;
        grCube = thisCard[0].grCube;
        brCube = thisCard[0].brCube;
        upGrade = thisCard[0].upGrade;
        thisSprite = thisCard[0].thisImage;

        thatImage.sprite = thisSprite;

        staticCardBack = cardBack;

        if(this.tag =="Clone"){
            // if(thisCard[0].id == 0 || thisCard[0].id == 1){
            //     thisCard[0] = PlayDeck.starterDeck[numberCard-1];
            //     numberCard -=1;
            //     PlayDeck.starSize -=1;
            //     cardBack = false;
            //     this.tag = "Untagged";
            // }else{
                if(numberOfCardInDeck>0){
                thisCard[0] = PlayDeck.staticDeck[numberOfCardInDeck-1];
                numberOfCardInDeck -=1;
                PlayDeck.deckSize -=1;
                cardBack = false;
                this.tag = "Untagged";
                }else{
                    thisCard[0] = PlayDeck.staticDeck[numberOfCardInDeck];
                    numberOfCardInDeck -=1;
                    PlayDeck.deckSize -=1;
                    cardBack = false;
                    this.tag = "Untagged";
                    //Debug.Log(PlayDeck.deckSize);
                }
        }   
    }

    public void UseCard(){
        if(TurnSystem.isYourTurn == true){
            if(check != Player){
                Debug.Log("You need hold this card to use");
            }else if(upGrade > 0){
                UpgradeCard();
            }else{
                    int x = reCube+yeCube+grCube+brCube;
                    int b = reCube + TurnSystem.currentRCube;
                    int a = yeCube + TurnSystem.currentYCube;
                    int c = grCube + TurnSystem.currentGrCube;
                    int d = brCube + TurnSystem.currentBrCube;

                    if(a<0 || b<0 || c<0 || d<0){
                        Debug.Log("nah nah nah");
                    }else{
                        TurnSystem.currentYCube = a;
                        TurnSystem.currentRCube = b;
                        TurnSystem.currentGrCube = c;
                        TurnSystem.currentBrCube = d;
                        TurnSystem.currentCube += x;
                        this.transform.SetParent(Used.transform);
                        this.transform.localScale = Vector3.one;
                        this.transform.position = new Vector3(transform.position.x, transform.position.y,0);
                        this.transform.eulerAngles = new Vector3(25,0,0);
                        int y = TurnSystem.currentCube;
                        if(y>10){
                            gameController.GetComponent<GameController>().OverCu();
                        }
                        gameController.GetComponent<GameController>().EndYourTurn();
                }
            }
        }
        //Debug.Log(y+"and all cube is"+x+"And red cube is"+b);
    }
    public void UpgradeCard(){
        //check = this.transform.parent.gameObject;
        if(TurnSystem.isYourTurn == true){
            if(check != Player){
                Debug.Log("You need hold this card to use");
            }else{
                int b = TurnSystem.currentRCube;
                int a = TurnSystem.currentYCube;
                int c = TurnSystem.currentGrCube;
                int d = TurnSystem.currentBrCube;

                if(a<2 && b<2 && c<2 && d<2){
                    Debug.Log("Not enough Cube for update");
                }else{
                    gameController.GetComponent<GameController>().Upgrate();
                    this.transform.SetParent(Used.transform);
                    this.transform.localScale = Vector3.one;
                    this.transform.position = new Vector3(transform.position.x, transform.position.y,0);
                    this.transform.eulerAngles = new Vector3(25,0,0);
                    gameController.GetComponent<GameController>().EndYourTurn();
                }     
            }     
        }
    }
}
