using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;
public class TriggerConts : MonoBehaviour


{
    // TARGETLER ELLERÝ KOLLARI TAKÝP ETMÝYOR ONU TAKÝP ETTÝRMEMÝZ LAZIM . 
    public MainConts main_character_control; //maincharacter scriptine eriþmek için tanýmladýðým deðiþken
    public BoolConts boolean_controls; //boolcontrols scriptine eriþmek için deðiþken tanýmladým
    public GameObject particleEffects; //çýkacak particle için 

    private void OnTriggerEnter(Collider other)
    {//TRÝGGERLAR KONTROL EDÝLÝR VE ANÝMASYONLAR BAÞLAR + WÝEGHTLERÝ KAPATIRIZ 


        //ÝLK ANÝMASYONDA ÇIKACAK TRÝGGERLAR TETÝKLENDÝKTEN SONRA BOOLAR TRUE OLACAK.
        if (other.tag == "LeftHand")
        {
            print("girdi");

            this.gameObject.SetActive(false);
            Instantiate(particleEffects, this.transform.position, Quaternion.identity);
            boolean_controls.leftHand = true;
            main_character_control.AtTheEndOfTheFirstAnimation();
        }
        if (other.tag == "RightHand")
        {
            print("girdi");
            this.gameObject.SetActive(false);
            Instantiate(particleEffects, this.transform.position, Quaternion.identity);

            boolean_controls.RightHand = true;
            main_character_control.AtTheEndOfTheFirstAnimation();
        }
        if (other.tag == "LeftFoot")
        {
            print("girdi");
            this.gameObject.SetActive(false);
            Instantiate(particleEffects, this.transform.position, Quaternion.identity);
            boolean_controls.leftFoot = true;
            main_character_control.AtTheEndOfTheFirstAnimation();
        }
        if (other.tag == "RightFoot")
        {
            print("girdi");
            this.gameObject.SetActive(false);
            Instantiate(particleEffects, this.transform.position, Quaternion.identity);
            boolean_controls.RightFoot = true;
            main_character_control.AtTheEndOfTheFirstAnimation();
        }
        if (other.tag == "Head")
        {
            print("girdi");
            this.gameObject.SetActive(false);
            Instantiate(particleEffects, this.transform.position, Quaternion.identity);
            boolean_controls.Head = true;
            main_character_control.AtTheEndOfTheFirstAnimation();
        }
        if (other.tag == "Chest")
        {
            print("girdi");
            this.gameObject.SetActive(false);
            Instantiate(particleEffects, this.transform.position, Quaternion.identity);
            boolean_controls.Chest = true;
            main_character_control.AtTheEndOfTheFirstAnimation();
        }

        //ÝKÝNCÝ ANÝMASYONDAN SONRA ÇIKACAK TRÝGGERLAR TETÝKLENÝNCE BOOLLAR TRUE OLACAK

        if (other.tag == "SecondLeftHand")
        {
            print("deðdi");
            this.gameObject.SetActive(false);
            Instantiate(particleEffects, this.transform.position, Quaternion.identity);
            boolean_controls.secondBoolLeftHand = true;
            main_character_control.AtTheEndOfTheSecondAnimation();
        }
        if (other.tag == "SecondRightHand")
        {
            this.gameObject.SetActive(false);
            Instantiate(particleEffects, this.transform.position, Quaternion.identity);
            boolean_controls.secondBoolRightHand = true;
            main_character_control.AtTheEndOfTheSecondAnimation();

        }
        if (other.tag == "SecondLeftFoot")
        {
            this.gameObject.SetActive(false);
           Instantiate(particleEffects, this.transform.position, Quaternion.identity);
            boolean_controls.secondBoolLeftFoot = true;
            main_character_control.AtTheEndOfTheSecondAnimation();

        }
        if (other.tag == "SecondRightFoot")
        {
            this.gameObject.SetActive(false);
           Instantiate(particleEffects, this.transform.position, Quaternion.identity);
            boolean_controls.secondBoolRightFoot = true;
            main_character_control.AtTheEndOfTheSecondAnimation();

        }
        if (other.tag == "SecondHead")
        {
            this.gameObject.SetActive(false);
            Instantiate(particleEffects, this.transform.position, Quaternion.identity);
            boolean_controls.secondBoolHead = true;
            main_character_control.AtTheEndOfTheSecondAnimation();
        }
        if (other.tag == "SecondChest")
        {
            this.gameObject.SetActive(false);
            Instantiate(particleEffects, this.transform.position, Quaternion.identity);
            boolean_controls.ChestSecond = true;
            main_character_control.AtTheEndOfTheSecondAnimation();
        }
    }


}
