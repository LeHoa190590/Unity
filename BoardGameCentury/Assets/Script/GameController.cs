using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;

public class GameController : NetworkBehaviour
{
    // Start is called before the first frame update
    public GameObject Obj;
    public GameObject[] pathPoint;
    public int point;
    public float speed;
    private Vector3 actualPosition;
    public int S1, S2, S3, S4, S5, S6;
    public int P1, P2, P3, P4, P5;

    public static bool emptySlot1 = true;
    public static bool emptySlot2 = true;
    public static bool emptySlot3 = true;
    public static bool emptySlot4 = true;
    public static bool emptySlot5 = true;
    public static bool emptySlot6 = true;
    public static bool emptyPoint1 = true;
    public static bool emptyPoint2 = true;
    public static bool emptyPoint3 = true;
    public static bool emptyPoint4 = true;
    public static bool emptyPoint5 = true;

    public static GameObject playSlot1;
    public static GameObject playSlot2;
    public static GameObject playSlot3;
    public static GameObject playSlot4;
    public static GameObject playSlot5;
    public static GameObject playSlot6;
    public static GameObject PointSlot1, PointSlot2, PointSlot3, PointSlot4, PointSlot5;
    public static int[,] Bonus = new int[4,5];

    public Text yeSlot2; 
    public Text yeSlot3, yeSlot4, yeSlot5, yeSlot6;
    public Text reSlot2, reSlot3, reSlot4, reSlot5, reSlot6;
    public Text grSlot2, grSlot3, grSlot4, grSlot5, grSlot6;
    public Text brSlot2, brSlot3, brSlot4, brSlot5, brSlot6;
    public GameObject OverCube, Confirm, over, common, Result;
    public Text yeCu, reCu, grCu, brCu, currentCu;
    public static bool yourGame, enemyGame, isEndGame;
    //public Button downCube;
    void Start()
    {
        playSlot1 = GameObject.Find("PlaySlot1");
        playSlot2 = GameObject.Find("PlaySlot2");
        playSlot3 = GameObject.Find("PlaySlot3");
        playSlot4 = GameObject.Find("PlaySlot4");
        playSlot5 = GameObject.Find("PlaySlot5");
        playSlot6 = GameObject.Find("PlaySlot6");
        PointSlot1 = GameObject.Find("PointSlot1");
        PointSlot2 = GameObject.Find("PointSlot2");
        PointSlot3 = GameObject.Find("PointSlot3");
        PointSlot4 = GameObject.Find("PointSlot4");
        PointSlot5 = GameObject.Find("PointSlot5");
        OverCube.SetActive(false);
        over.SetActive(false);
        common.SetActive(false);
        yourGame = false;
        enemyGame = false;
        isEndGame = false;
        Result.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        yeSlot6.text = ""+Bonus[0,0];
        reSlot6.text = ""+Bonus[1,0];
        grSlot6.text = ""+Bonus[2,0];
        brSlot6.text = ""+Bonus[3,0];
        yeSlot5.text = ""+Bonus[0,1];
        reSlot5.text = ""+Bonus[1,1];
        grSlot5.text = ""+Bonus[2,1];
        brSlot5.text = ""+Bonus[3,1];
        yeSlot4.text = ""+Bonus[0,2];
        reSlot4.text = ""+Bonus[1,2];
        grSlot4.text = ""+Bonus[2,2];
        brSlot4.text = ""+Bonus[3,2];
        yeSlot3.text = ""+Bonus[0,3];
        reSlot3.text = ""+Bonus[1,3];
        grSlot3.text = ""+Bonus[2,3];
        brSlot3.text = ""+Bonus[3,3];
        yeSlot2.text = ""+Bonus[0,4];
        reSlot2.text = ""+Bonus[1,4];
        grSlot2.text = ""+Bonus[2,4];
        brSlot2.text = ""+Bonus[3,4];
        yeCu.text = ""+TurnSystem.currentYCube;
        reCu.text = ""+TurnSystem.currentRCube;
        grCu.text = ""+TurnSystem.currentGrCube;
        brCu.text = ""+TurnSystem.currentBrCube;
        currentCu.text = "Your Current Cube Is: "+TurnSystem.currentCube;
    }
    public void EndGame(){
		Debug.Log("click on game controller");
		
		Time.timeScale = 0;
		
		
	}
    public void CheckEmpty(){
        S1 = playSlot1.transform.childCount;
        S2 = playSlot2.transform.childCount;
        S3 = playSlot3.transform.childCount;
        S4 = playSlot4.transform.childCount;
        S5 = playSlot5.transform.childCount;
        S6 = playSlot6.transform.childCount;
        P1 = PointSlot1.transform.childCount;
        P2 = PointSlot2.transform.childCount;
        P3 = PointSlot3.transform.childCount;
        P4 = PointSlot4.transform.childCount;
        P5 = PointSlot5.transform.childCount;
        if(S1 == 0){
            emptySlot1 = true;
        }else{
            emptySlot1 = false;
        }
        if(S2 == 0){
            emptySlot2 = true;
        }else{
            emptySlot2 = false;
        }
        if(S3 == 0){
            emptySlot3 = true;
        }else{
            emptySlot3 = false;
        }
        if(S4 == 0){
            emptySlot4 = true;
        }else{
            emptySlot4 = false;
        }
        if(S5 == 0){
            emptySlot5 = true;
        }else{
            emptySlot5 = false;
        }
        if(S6 == 0){
            emptySlot6 = true;
        }else{
            emptySlot6 = false;
        }
        if(P1 == 0){
            emptyPoint1 = true;
        }else{
            emptyPoint1 = false;
        }
        if(P2 == 0){
            emptyPoint2 = true;
        }else{
            emptyPoint2 = false;
        }
        if(P3 == 0){
            emptyPoint3 = true;
        }else{
            emptyPoint3 = false;
        }
        if(P4 == 0){
            emptyPoint4 = true;
        }else{
            emptyPoint4 = false;
        }
        if(P5 == 0){
            emptyPoint5 = true;
        }else{
            emptyPoint5 = false;
        }
    }

    public void OverCu(){
        OverCube.SetActive(true);
        over.SetActive(true);
        Confirm.SetActive(false);   
    }
    public void DownYe(){
        if(TurnSystem.currentYCube > 0 && TurnSystem.currentCube > 10){
            TurnSystem.currentYCube -=1;
            CheckOver();
        }else{
            return;
        }
    }
    public void DownRe(){
        if(TurnSystem.currentRCube > 0 && TurnSystem.currentCube > 10){ 
            TurnSystem.currentRCube -=1;
            CheckOver();
        }else{
            return;
        }
    }
    public void DownGr(){
        if(TurnSystem.currentGrCube > 0 && TurnSystem.currentCube > 10){
            TurnSystem.currentGrCube -=1;
            CheckOver();
        }else{
            return;
        }
    }
    public void DownBr(){
        if(TurnSystem.currentBrCube > 0 && TurnSystem.currentCube > 10){
            TurnSystem.currentBrCube -=1;
            CheckOver();
        }else{
            return;
        }
    }
    public void CheckOver(){
        int a = TurnSystem.currentCube;
        if(a <= 11){
            Confirm.SetActive(true);
        }else{
            Confirm.SetActive(false);
        }
    }
    public void ItOk(){
        OverCube.SetActive(false);
        over.SetActive(false);
        common.SetActive(false);
        Confirm.SetActive(false);
        //upgrate.SetActive(false);
    }

    public void Upgrate(){
        OverCube.SetActive(true);
        common.SetActive(true);
        Confirm.SetActive(false);
    }
    public void UpYe(){
        if(TurnSystem.currentYCube > 1){
            TurnSystem.currentYCube -=2;
            TurnSystem.currentRCube +=1;
            Confirm.SetActive(true);
        }else{
            return;
        }
    }
    public void UpRe(){
        if(TurnSystem.currentRCube > 1){
            TurnSystem.currentRCube -=2;
            TurnSystem.currentGrCube +=1;
            Confirm.SetActive(true);
        }else{
            return;
        }
    }
    public void UpGr(){
        if(TurnSystem.currentGrCube > 1){
            TurnSystem.currentGrCube -=2;
            TurnSystem.currentBrCube +=1;
            Confirm.SetActive(true);
        }else{
            return;
        }
    }
    public void EndYourTurn(){
        TurnSystem.isYourTurn = false;
        TurnSystem.yourOponentTurn +=1;
        CheckEndGame();
    }

    public void EndYourOponentTurn(){
        TurnSystem.isYourTurn = true;
        TurnSystem.yourTurn +=1;
        CheckEndGame();
    }
    public void CheckEndGame(){
        if(yourGame == true && enemyGame == true){
            isEndGame = true;
            Time.timeScale = 0;
            Result.SetActive(true);
        }
    }
}
