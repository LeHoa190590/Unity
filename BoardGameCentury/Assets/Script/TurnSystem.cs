using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnSystem : MonoBehaviour
{
    public static bool isYourTurn;
    public static int yourTurn;
    public static int yourOponentTurn;
    public Text turnText;
    public static int maxCube;
    public static int currentCube;
    public Text cYCube;
    public Text cRCube;
    public Text cGrCube;
    public Text cBrCube;
    public Text yPoint, yCard, totalY, totalE;
    public static int currentYCube;
    public static int currentRCube;
    public static int currentGrCube;
    public static int currentBrCube;
    public static int yourPoint, yourTotalCard, enemyPoint;
    
    // Start is called before the first frame update
    void Start()
    {
        isYourTurn = true;
        yourTurn = 1;
        yourOponentTurn = 0;
        maxCube = 10;
        currentCube = 0;
        currentYCube = 0;
        currentRCube = 0;
        currentGrCube = 0;
        currentBrCube = 0;
        yourPoint = 0;
        yourTotalCard = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(isYourTurn == true){
            turnText.text = "your turn";
        }else{
            turnText.text = "your oponent turn";
        }
        cYCube.text = "X"+currentYCube;
        cRCube.text = "X"+currentRCube;
        cGrCube.text = "X"+currentGrCube;
        cBrCube.text = "X"+currentBrCube;
        yPoint.text = "Your point is: "+yourPoint;
        currentCube = currentYCube+currentRCube+currentGrCube+currentBrCube;
        yCard.text = "Total Point Card: "+yourTotalCard;
        totalY.text = "Total Point You Have:"+yourPoint;
        totalE.text = "Total Point Enemy Have:"+enemyPoint;
    }

    public void EndYourTurn(){
        isYourTurn = false;
        yourOponentTurn +=1;
    }

    public void EndYourOponentTurn(){
        isYourTurn = true;
        yourTurn +=1;
    }
}
