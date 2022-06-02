using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointDeck : MonoBehaviour
{
    public List<PointCard> pointDeck = new List<PointCard> ();
    public List<PointCard> containerPoint = new List<PointCard> ();
    public static List<PointCard> staDeck = new List<PointCard> ();
    public int x;
    public bool emptySlot = false;

    public GameObject PointToSlot;
    public GameObject CardBack;
    public GameObject Deck;
    public GameObject[] Clones;
    public GameObject Slot;
    public static int pointDeckSize;
    public GameObject pointCardInDeck;

    // Start is called before the first frame update
    void Start()
    {  
        x=18;
        pointDeckSize = 18;
        for(int i=0; i<pointDeckSize; i++){
            pointDeck[i] = CardDatabase.pointList[i];
        }
        shuffle();
        //StartCoroutine(FillSlot());
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(GameController.emptySlot1);
        staDeck = pointDeck;
        if(pointDeckSize<1){
            pointCardInDeck.SetActive(false);
        }
        if(pointDeckSize>0 && GameController.emptyPoint1 == true){
            StartCoroutine(Draw(1));
            emptySlot = false;
            GameController.emptyPoint1 = false;
        }
        
    }
    IEnumerator FillSlot(){ 
        
        yield return new WaitForSeconds(1);
        Instantiate(PointToSlot, transform.position, transform.rotation);
    }
    IEnumerator Example(){
        yield return new WaitForSeconds(1);
        Clones = GameObject.FindGameObjectsWithTag("Clone"); //remember FindGameObjectsWithTag =/= FindGameObjectWithTag
        foreach(GameObject Clone in Clones){
            Destroy(Clone);
        }
    }

    public void shuffle(){
        for(int i=0; i<pointDeckSize; i++){
            containerPoint[0] = pointDeck[i];
            int randomIndex = Random.Range(i, pointDeckSize);
            pointDeck[i]= pointDeck[randomIndex];
            pointDeck[randomIndex] = containerPoint[0];
        }
        Instantiate(CardBack, transform.position, transform.rotation);
        StartCoroutine(Example());
    }
    IEnumerator Draw(int x){
        for(int i=0; i<x; i++){
            yield return new WaitForSeconds(1);
            Instantiate(PointToSlot, transform.position, transform.rotation);
        }
    }
}
