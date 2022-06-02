using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]

public class PointCard
{
    public int id;
    public int yeCube;
    public int reCube;
    public int grCube;
    public int brCube;
    public int point;
    public Sprite thisImage;

    public PointCard(){

    }

    public PointCard(int Id, int YeCube, int ReCube, int GrCube, int BrCube, int Point, Sprite ThisImage){
        id = Id;
        yeCube = YeCube;
        reCube = ReCube;
        grCube = GrCube;
        brCube = BrCube;
        point = Point;
        thisImage = ThisImage;
    }
}
