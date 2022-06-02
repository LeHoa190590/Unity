using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card> ();
    public static List<PointCard> pointList = new List<PointCard> ();

    void Awake(){
        cardList.Add (new Card(0,0,0,0,0,2, Resources.Load<Sprite>("Playcard 00")));
        cardList.Add (new Card(1,2,0,0,0,0, Resources.Load<Sprite>("Playcard 01")));
        cardList.Add (new Card(2,3,0,0,0,0, Resources.Load<Sprite>("Playcard 02")));
        cardList.Add (new Card(3,-2,0,-1,2,0, Resources.Load<Sprite>("Playcard 03")));
        cardList.Add (new Card(4,0,2,0,0,0, Resources.Load<Sprite>("Playcard 04")));
        cardList.Add (new Card(5,1,1,1,-1,0, Resources.Load<Sprite>("Playcard 05")));
        cardList.Add (new Card(6,2,1,-2,1,0, Resources.Load<Sprite>("Playcard 06")));
        cardList.Add (new Card(7,0,2,-2,1,0, Resources.Load<Sprite>("Playcard 07")));
        cardList.Add (new Card(8,-2,2,0,0,0, Resources.Load<Sprite>("Playcard 08")));
        cardList.Add (new Card(9,-4,0,1,1,0, Resources.Load<Sprite>("Playcard 09")));
        cardList.Add (new Card(10,-3,0,0,1,0, Resources.Load<Sprite>("Playcard 10")));
        cardList.Add (new Card(11,0,0,1,0,0, Resources.Load<Sprite>("Playcard 11")));
        cardList.Add (new Card(12,1,2,-1,0,0, Resources.Load<Sprite>("Playcard 12")));
        cardList.Add (new Card(13,0,3,0,-1,0, Resources.Load<Sprite>("Playcard 13")));
        cardList.Add (new Card(14,4,1,-1,0,0, Resources.Load<Sprite>("Playcard 14")));
        cardList.Add (new Card(15,2,1,0,0,0, Resources.Load<Sprite>("Playcard 15")));
        cardList.Add (new Card(16,-2,0,1,0,0, Resources.Load<Sprite>("Playcard 16")));
        cardList.Add (new Card(17,2,2,0,-1,0, Resources.Load<Sprite>("Playcard 17")));
        cardList.Add (new Card(18,1,-3,1,1,0, Resources.Load<Sprite>("Playcard 18")));
        cardList.Add (new Card(19,-4,2,1,0,0, Resources.Load<Sprite>("Playcard 19")));
        cardList.Add (new Card(20,0,0,-3,3,0, Resources.Load<Sprite>("Playcard 20")));
        cardList.Add (new Card(21,0,2,-1,0,0, Resources.Load<Sprite>("Playcard 21")));
        cardList.Add (new Card(22,0,0,0,1,0, Resources.Load<Sprite>("Playcard 22")));
        cardList.Add (new Card(23,1,1,0,0,0, Resources.Load<Sprite>("Playcard 23")));
        cardList.Add (new Card(24,-5,0,3,0,0, Resources.Load<Sprite>("Playcard 24")));
        cardList.Add (new Card(25,1,0,1,0,0, Resources.Load<Sprite>("Playcard 25")));
        cardList.Add (new Card(26,4,0,0,0,0, Resources.Load<Sprite>("Playcard 26")));
        cardList.Add (new Card(27,-1,-1,0,1,0, Resources.Load<Sprite>("Playcard 27")));
        cardList.Add (new Card(28,3,-1,0,0,0, Resources.Load<Sprite>("Playcard 28")));
        cardList.Add (new Card(29,-3,1,1,0,0, Resources.Load<Sprite>("Playcard 29")));
        cardList.Add (new Card(30,-5,0,0,2,0, Resources.Load<Sprite>("Playcard 30")));


        pointList.Add (new PointCard(0,2,2,0,2,15, Resources.Load<Sprite>("Pointcard 01")));
        pointList.Add (new PointCard(1,0,5,0,0,10, Resources.Load<Sprite>("Pointcard 02")));
        pointList.Add (new PointCard(2,3,2,0,0,7, Resources.Load<Sprite>("Pointcard 03")));
        pointList.Add (new PointCard(3,0,0,5,0,15, Resources.Load<Sprite>("Pointcard 04")));
        pointList.Add (new PointCard(4,2,1,0,1,9, Resources.Load<Sprite>("Pointcard 05")));
        pointList.Add (new PointCard(5,0,0,2,3,18, Resources.Load<Sprite>("Pointcard 06")));
        pointList.Add (new PointCard(6,1,1,1,3,20, Resources.Load<Sprite>("Pointcard 07")));
        pointList.Add (new PointCard(7,0,2,2,2,19, Resources.Load<Sprite>("Pointcard 08")));
        pointList.Add (new PointCard(8,2,0,2,2,17, Resources.Load<Sprite>("Pointcard 09")));
        pointList.Add (new PointCard(9,3,0,0,2,11, Resources.Load<Sprite>("Pointcard 10")));
        pointList.Add (new PointCard(10,2,2,0,0,6, Resources.Load<Sprite>("Pointcard 11")));
        pointList.Add (new PointCard(11,2,0,3,0,11, Resources.Load<Sprite>("Pointcard 12")));
        pointList.Add (new PointCard(12,2,0,2,0,8, Resources.Load<Sprite>("Pointcard 13")));
        pointList.Add (new PointCard(13,0,4,0,0,8, Resources.Load<Sprite>("Pointcard 14")));
        pointList.Add (new PointCard(14,0,0,0,5,20, Resources.Load<Sprite>("Pointcard 15")));
        pointList.Add (new PointCard(15,0,2,0,3,16, Resources.Load<Sprite>("Pointcard 16")));
        pointList.Add (new PointCard(16,2,3,0,0,8, Resources.Load<Sprite>("Pointcard 17")));
        pointList.Add (new PointCard(17,0,2,0,2,12, Resources.Load<Sprite>("Pointcard 18")));

    }
}
