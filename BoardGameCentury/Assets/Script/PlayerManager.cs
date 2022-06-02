using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerManager : NetworkBehaviour
{
    public GameObject Card1, Card2, Card3;
    public GameObject PlayerHand, EnemyHand;
    public GameObject PlayerCard, EnemyCard;
    public GameObject PlayerPointPanel, EnemyPointPanel;
    public GameObject PS1;
    public int number;
    List<GameObject> card = new List<GameObject>();
    public override void OnStartClient()
    {
        base.OnStartClient();
        PlayerHand = GameObject.Find("PlayerHand");
        EnemyHand = GameObject.Find("EnemyHand");
        PlayerCard = GameObject.Find("PlayerCard");
        EnemyCard = GameObject.Find("EnemyCard");
        PlayerPointPanel = GameObject.Find("PlayerPointPanel");
        EnemyPointPanel = GameObject.Find("EnemyPointPanel");
    }
    [Server]
    public override void OnStartServer()
    {
        base.OnStartServer();
        //card.Add(Card1);
        //card.Add(Card2);
       // Debug.Log(PlayerCard.transform.childCount);
        
    }
    [Command]
    public void CmdBuyS6(){
        if(TurnSystem.isYourTurn == true){
            PS1 = GameObject.Find("PlaySlot6");
            number = PS1.transform.childCount;
            Card3 = PS1.gameObject.transform.GetChild(0).gameObject;
            if(number == 0){
                Debug.Log("bug");
            }else{
                Card3.transform.SetParent(PlayerHand.transform);
                Card3.transform.localScale = Vector3.one;
                Card3.transform.position = new Vector3(transform.position.x, transform.position.y,0);
                Card3.transform.eulerAngles = new Vector3(25,0,0);
            }
            //gameController.GetComponent<GameController>().CheckEmpty();
            //gameController.GetComponent<GameController>().EndYourTurn();
        }
    }
    [ClientRpc]
    void RpcShowCard(){
        
    }
}
