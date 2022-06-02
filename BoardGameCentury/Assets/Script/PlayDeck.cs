using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayDeck : MonoBehaviour
{
    public List<Card> deck = new List<Card> ();
    public List<Card> starDeck = new List<Card>();
    public List<Card> container = new List<Card> ();
    public static List<Card> staticDeck = new List<Card> ();
    public static List<Card> starterDeck = new List<Card> ();

    public static int deckSize, starSize;
    public int x;
    public GameObject cardInDeck;
    public bool emptySlot = false;

    public GameObject CardToSlot, CardToHand;
    public GameObject CardBack;
    public GameObject Deck, startDeck;
    public GameObject[] Clones;
    public GameObject Slot;

    // Start is called before the first frame update
    void Start()
    {  
        deckSize = 29;
        for(int i=0; i<29; i++){
            deck[i] = CardDatabase.cardList[i+2];
        }   
        //StartCoroutine(Draw(1));
        shuffle();
        starSize = 2;
        // for(x=0;x<2;x++){
        //     starDeck[x] = CardDatabase.cardList[x];
        // }
        //StartCoroutine(FillSlot());
        //transfer();
    }

    // Update is called once per frame
    void Update()
    {
        staticDeck = deck;
        if(deckSize<1){
            cardInDeck.SetActive(false);
        }
        if(deckSize>0 && GameController.emptySlot1 == true){
            StartCoroutine(Draw(1));
            emptySlot = false;
            GameController.emptySlot1 = false;
        }
        starterDeck = starDeck;
    }

    IEnumerator FillSlot(){    
        yield return new WaitForSeconds(5);
        Instantiate(CardToHand, transform.position, transform.rotation);
    }

    IEnumerator Example(){
        yield return new WaitForSeconds(1);
        Clones = GameObject.FindGameObjectsWithTag("Clone"); //remember FindGameObjectsWithTag =/= FindGameObjectWithTag
        foreach(GameObject Clone in Clones){
            Destroy(Clone);
        }
    }

    public void shuffle(){
        for(int i=0; i<deckSize; i++){
            container[0] = deck[i];
            int randomIndex = Random.Range(i, deckSize);
            deck[i]= deck[randomIndex];
            deck[randomIndex] = container[0];
        }

        Instantiate(CardBack, transform.position, transform.rotation);
        StartCoroutine(Example());
    }

    IEnumerator Draw(int x){
        for(int i=0; i<x; i++){
            yield return new WaitForSeconds(1);
            Instantiate(CardToSlot, transform.position, transform.rotation);
        }
    }
    // IEnumerator Begin(){
    //     yield return new WaitForSeconds(1);
    //     Instantiate(CardToHand, transform.position, transform.rotation);
    // }
}
