using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]

public class Card
{
    public int id;
    public int yeCube;
    public int reCube;
    public int grCube;
    public int brCube;
    public int upGrade;
    public Sprite thisImage;

    public Card(){

    }

    public Card(int Id, int YeCube, int ReCube, int GrCube, int BrCube, int UpGrade, Sprite ThisImage){
        id = Id;
        yeCube = YeCube;
        reCube = ReCube;
        grCube = GrCube;
        brCube = BrCube;
        upGrade = UpGrade;
        thisImage = ThisImage;
    }
}
