using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolConts : MonoBehaviour
{   //maincharacter scriptine eriþmek için tanýmladýðým deðiþken
    public MainConts main_character;
    //ÝLK ANÝMASYONUN KONTROL EDÝLMESÝ ÝÇÝN GEREKLÝ BOOLLAR
    public bool Head = false;
    public bool RightHand = false;
    public bool RightFoot = false;
    public bool leftHand = false;
    public bool leftFoot = false;
    public bool fallAnim = false;
    public bool Chest = false;
    // ÝKÝNCÝ ANÝMASYONU KONTROL EDÝLMESÝ ÝÇÝN GEREKLÝ BOOLAR
    public bool secondBoolHead = false;
    public bool secondBoolRightHand = false;
    public bool secondBoolRightFoot = false;
    public bool secondBoolLeftHand = false;
    public bool secondBoolLeftFoot = false;
    public bool secondBoolfallAnim = false;
    public bool ChestSecond = false;


    public bool firstContorl = true; // ilk animasyonun ifleri ve else ifleri sürekli çalýþmamasý için 
    public bool secondControl = true; // ikinci animasyonun ifleri ve else ifleri sürekli çalýþmamasý için

    public bool CircleTrigger = false; // trigger tetiklenince circle haraketini kapatacak

}
