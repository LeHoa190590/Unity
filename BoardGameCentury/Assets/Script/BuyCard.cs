using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class BuyCard : NetworkBehaviour
{
    public PlayerManager PlayerManager;
    public GameObject Card1;
    public GameObject Card2;
    public GameObject PlayerPointPanel;
    public int number;
    public GameObject PS1;
    GameObject gameController;
    //public static bool emptySlot1;
   
    
    void Start()
    {
        if(gameController == null){
            gameController = GameObject.FindGameObjectWithTag("GameController");
        }
        
        Card2 = GameObject.Find("PlayerHand");
        PlayerPointPanel = GameObject.Find("PlayerPointPanel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BuySlot1(){
        if(TurnSystem.isYourTurn == true){
            if(TurnSystem.currentCube >= 5 ){        
                PS1 = GameObject.Find("PlaySlot1");
                number = PS1.transform.childCount;//get number child of panel
                Card1 = PS1.gameObject.transform.GetChild(0).gameObject;//Get component child
                if(number == 0){
                    Debug.Log("There No Card in this Slot");
                }else{
                    Card1.transform.SetParent(Card2.transform);
                    Card1.transform.localScale = Vector3.one;
                    Card1.transform.position = new Vector3(transform.position.x, transform.position.y,0);
                    Card1.transform.eulerAngles = new Vector3(25,0,0);
                }
                BuyPlayCard(5);
                gameController.GetComponent<GameController>().CheckEmpty();// use void checkempty() from class GameController
                gameController.GetComponent<GameController>().EndYourTurn();
            }else{
                Debug.Log("Not Enough Cube for buy this Card");
            }
        } 
    }
    public void BuySlot2(){
        if(TurnSystem.isYourTurn == true){
            if(TurnSystem.currentCube >= 4 ){
                PS1 = GameObject.Find("PlaySlot2");
                number = PS1.transform.childCount;
                Card1 = PS1.gameObject.transform.GetChild(0).gameObject;
                if(number == 0){
                    Debug.Log("bug");
                }else{
                    Card1.transform.SetParent(Card2.transform);
                    Card1.transform.localScale = Vector3.one;
                    Card1.transform.position = new Vector3(transform.position.x, transform.position.y,0);
                    Card1.transform.eulerAngles = new Vector3(25,0,0);
                }
                BuyPlayCard(4);
                gameController.GetComponent<GameController>().CheckEmpty();
                gameController.GetComponent<GameController>().EndYourTurn();
            }else{
                Debug.Log("Not Enough Cube for buy this Card");
            }
        }
    }
    public void BuySlot3(){
        if(TurnSystem.isYourTurn == true){
            if(TurnSystem.currentCube >= 3 ){
                PS1 = GameObject.Find("PlaySlot3");
                number = PS1.transform.childCount;
                Card1 = PS1.gameObject.transform.GetChild(0).gameObject;
                if(number == 0){
                    Debug.Log("bug");
                }else{
                    Card1.transform.SetParent(Card2.transform);
                    Card1.transform.localScale = Vector3.one;
                    Card1.transform.position = new Vector3(transform.position.x, transform.position.y,0);
                    Card1.transform.eulerAngles = new Vector3(25,0,0);
                }
                BuyPlayCard(3);
                gameController.GetComponent<GameController>().CheckEmpty();
                gameController.GetComponent<GameController>().EndYourTurn();
            }else{
                Debug.Log("Not Enough Cube for buy this Card");
            }
        }
    }
    public void BuySlot4(){
        if(TurnSystem.isYourTurn == true){
            if(TurnSystem.currentCube >= 2 ){
                PS1 = GameObject.Find("PlaySlot4");
                number = PS1.transform.childCount;
                Card1 = PS1.gameObject.transform.GetChild(0).gameObject;
                if(number == 0){
                    Debug.Log("bug");
                }else{
                    Card1.transform.SetParent(Card2.transform);
                    Card1.transform.localScale = Vector3.one;
                    Card1.transform.position = new Vector3(transform.position.x, transform.position.y,0);
                    Card1.transform.eulerAngles = new Vector3(25,0,0);
                }
                BuyPlayCard(2);
                gameController.GetComponent<GameController>().CheckEmpty();
                gameController.GetComponent<GameController>().EndYourTurn();
            }else{
                Debug.Log("Not Enough Cube for buy this Card");
            }
        }
    }
    public void BuySlot5(){
        if(TurnSystem.isYourTurn == true){
            if(TurnSystem.currentCube >= 1 ){ 
                PS1 = GameObject.Find("PlaySlot5");
                number = PS1.transform.childCount;
                Card1 = PS1.gameObject.transform.GetChild(0).gameObject;
                if(number == 0){
                    Debug.Log("bug");
                }else{
                    Card1.transform.SetParent(Card2.transform);
                    Card1.transform.localScale = Vector3.one;
                    Card1.transform.position = new Vector3(transform.position.x, transform.position.y,0);
                    Card1.transform.eulerAngles = new Vector3(25,0,0);
                }
                BuyPlayCard(1);
                gameController.GetComponent<GameController>().CheckEmpty();
                gameController.GetComponent<GameController>().EndYourTurn();
            }else{
                Debug.Log("Not Enough Cube for buy this Card");
            }
        }
    }
    // public void BuySlot6(){
    //     if(TurnSystem.isYourTurn == true){
    //         PS1 = GameObject.Find("PlaySlot6");
    //         number = PS1.transform.childCount;
    //         Card1 = PS1.gameObject.transform.GetChild(0).gameObject;
    //         if(number == 0){
    //             Debug.Log("bug");
    //         }else{
    //             Card1.transform.SetParent(Card2.transform);
    //             Card1.transform.localScale = Vector3.one;
    //             Card1.transform.position = new Vector3(transform.position.x, transform.position.y,0);
    //             Card1.transform.eulerAngles = new Vector3(25,0,0);
    //         }
    //         gameController.GetComponent<GameController>().CheckEmpty();
    //         gameController.GetComponent<GameController>().EndYourTurn();
    //     }
    // }
    public void BuySlot6(){
        NetworkIdentity networkIdentity = NetworkClient.connection.identity;
        PlayerManager = networkIdentity.GetComponent<PlayerManager>();
        PlayerManager.CmdBuyS6();
        gameController.GetComponent<GameController>().CheckEmpty();
        gameController.GetComponent<GameController>().EndYourTurn();
    
    }
    //Get the card back
    public void ComeBack(){
        if(TurnSystem.isYourTurn == true){
            PS1 = GameObject.Find("PlayerCard");
            number = PS1.transform.childCount;
            //Card1 = PS1.gameObject.transform.GetChild(0).gameObject;
            
            if(number == 0){
                Debug.Log("bug");
            }else{
                for(int i = 0; i < number; i++){
                Card1 = PS1.gameObject.transform.GetChild(0).gameObject;
                Card1.transform.SetParent(Card2.transform);
                Card1.transform.localScale = Vector3.one;
                Card1.transform.position = new Vector3(transform.position.x, transform.position.y,0);
                Card1.transform.eulerAngles = new Vector3(25,0,0);
                }
            }
            gameController.GetComponent<GameController>().CheckEmpty();
            gameController.GetComponent<GameController>().EndYourTurn();
        }
    }
    public void BuyPlayCard(int x){
        int[,] bn = new int[4,x];
        int a = TurnSystem.currentYCube;
        int b = TurnSystem.currentRCube;
        int c = TurnSystem.currentGrCube;
        int d = TurnSystem.currentBrCube;
        int e = a;
        int f = b;
        int g = c;
        for(int i=0; i<x; i++){
            if(a==0){
                break;
            }
            bn[0,i] = 1;
            a--;        
        }
        for(int y = e; y<x; y++){        
            if(b==0){
                break;
            }
            bn[1,y] = 1;
            b--;        
        }       
        for(int j = e+f; j<x;j++){
            if(c==0){
                break;
            }
            bn[2,j] = 1;
            c--;     
        }
        for(int k=e+f+g; k<x; k++){
            if(a+b+c >= x){
                break;
            }
            bn[3,k] = 1;
            d--;
        }
        TurnSystem.currentYCube = a;
        TurnSystem.currentRCube = b;
        TurnSystem.currentGrCube = c;
        TurnSystem.currentBrCube = d;
        for(int ye = 0; ye<x; ye++){
            GameController.Bonus[0,ye] += bn[0,ye];
            GameController.Bonus[1,ye] += bn[1,ye];
            GameController.Bonus[2,ye] += bn[2,ye];
            GameController.Bonus[3,ye] += bn[3,ye];
        }   
    }

}
