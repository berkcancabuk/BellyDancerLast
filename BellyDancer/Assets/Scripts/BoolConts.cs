using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolConts : MonoBehaviour
{   //maincharacter scriptine eri�mek i�in tan�mlad���m de�i�ken
    public MainConts main_character;
    //�LK AN�MASYONUN KONTROL ED�LMES� ���N GEREKL� BOOLLAR
    public bool Head = false;
    public bool RightHand = false;
    public bool RightFoot = false;
    public bool leftHand = false;
    public bool leftFoot = false;
    public bool fallAnim = false;
    public bool Chest = false;
    // �K�NC� AN�MASYONU KONTROL ED�LMES� ���N GEREKL� BOOLAR
    public bool secondBoolHead = false;
    public bool secondBoolRightHand = false;
    public bool secondBoolRightFoot = false;
    public bool secondBoolLeftHand = false;
    public bool secondBoolLeftFoot = false;
    public bool secondBoolfallAnim = false;
    public bool ChestSecond = false;


    public bool firstContorl = true; // ilk animasyonun ifleri ve else ifleri s�rekli �al��mamas� i�in 
    public bool secondControl = true; // ikinci animasyonun ifleri ve else ifleri s�rekli �al��mamas� i�in

    public bool CircleTrigger = false; // trigger tetiklenince circle haraketini kapatacak

}
