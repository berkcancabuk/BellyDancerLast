using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;
using UnityEngine.SceneManagement;
using TMPro;

public class MainConts : MonoBehaviour
{
    public int a = 1;
    public int b = 1;
    public GameObject firstAnim; //ÝLK ANÝMASYON
    public GameObject SecondAnim; //ÝKÝNCÝ ANÝMASYON
    public GameObject firstTriggerObjects; // ÝLK TRÝGGER OBJELERÝ
    public GameObject secondTriggerObjects; // ÝKÝNCÝ TRÝGGER OBJELERÝ
    public GameObject circle1; //Dairelerin çýkýp çýkmayacaðýna karar vermek için.
    public GameObject circle2;
    public GameObject circle3;
    public GameObject circle4;
    public GameObject circle5;
    public GameObject circle6;
    public GameObject settingPlane;
    public GameObject havaiFisek;
    public bool asd = false;
    public bool oyundurdumu = false;
    //ELLERÝN KOLLARIN HARAKETÝNÝ ETKÝNLEÞTÝRMEK ÝÇÝN
    public GameObject weightLeftHand;
    public GameObject weightLeftFoot;
    public GameObject weightChest;
    public GameObject weightRightFoot;
    public GameObject weightRightHand;
    public GameObject weightHead;
    public Animator AnimController; //ANÝMASYON ÇALIÞTIRMASI ÝÇÝN VE GEÇÝÞLER ÝÇÝN
    public Transform camTransform;
    public BoolConts boolean; //boolcontrols scriptine eriþmek için deðiþken tanýmladým
    //public TextMeshProUGUI level;
    public GameObject amazingTextGameobje; //amazing yazýsý çýkmasýný saðlayan gameobject
    public GameObject greatTextGameobje; // great + konfeti çýkacak
    public GameObject youWinTextGameobje; // youwin yazýsý
    public TextMeshProUGUI level;
    public GameObject loseSceneGameobje; //lose yazýsý animasyonunu etkinleþtiren gameobje

    // Start is called before the first frame update
    void Start()
    {
        level.text = "Level: " + a;
        a++;
        //level.text = "Level" + a;

        
        StartCoroutine(TimeToStartThefirstAnimation());
        //StartCoroutine(THEYWILLBEAFTER13SECONDS());
        StartCoroutine(FirstTriggerObjectSecond());
        /*tartCoroutine(THEYWILLBESCONDAFTER18SECONDS());*/
    }
    // Update is called once per frame
    void Update()
    {
        circle4.transform.localPosition = new Vector3(0.003f, -0.036f, 0.203f);
        circle5.transform.localPosition = new Vector3(-0.02537534f, 0.1619123f, 0.1794534f);
        circle6.transform.localPosition = new Vector3(0.01535024f, 0.1602309f, 0.1613519f);
        circle1.transform.rotation = camTransform.rotation;
        circle2.transform.rotation = camTransform.rotation;
        circle3.transform.rotation = camTransform.rotation;
        circle4.transform.rotation = camTransform.rotation;
        circle5.transform.rotation = camTransform.rotation;
        circle6.transform.rotation = camTransform.rotation;
    }

    IEnumerator FirstTriggerObjectSecond()
    {
        yield return new WaitForSeconds(1f);
        firstTriggerObjects.SetActive(true);
    }
    IEnumerator SecondTriggerObjectSecond()
    {
        yield return new WaitForSeconds(6f);
        secondTriggerObjects.SetActive(true);
    }
    IEnumerator TimeToStartThefirstAnimation()
    {//ilk animasyon için beklenecek süre geçtikten sonra ilk animasyonu baþlatýyor + ilk triggirlanacak objeleri açýyor + riglerin weightlerini 1 yapýyor.
        yield return new WaitForSeconds(6f);
        firstAnim.SetActive(true);
        boolean.CircleTrigger = true;
        AnimController.speed = 0;
        circle1.SetActive(true);
        circle2.SetActive(true);
        circle3.SetActive(true);
        circle4.SetActive(true);
        circle5.SetActive(true);
        circle6.SetActive(true);
        WeightOpen();
        yield return new WaitForSeconds(10f);
        print("10sn geçti");
        //triggerlarýn hepsi true olmazsa fallanim true olucak ve düþme animasyonuna geçicek
        if (boolean.fallAnim == true)
        {
            circle1.SetActive(false);
            circle2.SetActive(false);
            circle3.SetActive(false);
            circle4.SetActive(false);
            circle5.SetActive(false);
            circle6.SetActive(false);
            print("falls");
            loseSceneGameobje.SetActive(true);
            AnimController.speed = 1;
            firstAnim.SetActive(false);
            firstTriggerObjects.SetActive(false);
            circle1.SetActive(false);
            WeightClose();
            AnimController.SetBool("Fall", true);
        }

    }

    IEnumerator TimeToStartTheSecondAnimation()
    {
        //ikinci animasyon için beklenecek süre geçtikten sonra ikinci animasyonu baþlatýyor + ikinci triggirlanacak objeleri açýyor + riglerin weightlerini 1 yapýyor.
        yield return new WaitForSeconds(15.2f);
        print("15.2sn geçti");
        SecondAnim.SetActive(true);
        boolean.CircleTrigger = true;
        WeightOpen();
        asd = true;
        circle1.SetActive(true);
        circle2.SetActive(true);
        circle3.SetActive(true);
        
        circle4.SetActive(true);
        
        circle5.SetActive(true);
        circle6.SetActive(true);
        yield return new WaitForSeconds(10f);
        //triggerlarýn hepsi true olmazsa fallanim true olucak ve düþme animasyonuna geçicek
        print("10 sn geçti");
        if (boolean.secondBoolfallAnim == false)
        {
            circle1.SetActive(false);
            circle2.SetActive(false);
            circle3.SetActive(false);
            circle4.SetActive(false);
            circle5.SetActive(false);
            circle6.SetActive(false);
            loseSceneGameobje.SetActive(true);
            AnimController.SetBool("Fall", true);
            AnimController.speed = 1;
            boolean.CircleTrigger = false;
            SecondAnim.SetActive(false);
            secondTriggerObjects.SetActive(false);
            circle1.SetActive(false);
            WeightClose();
        }
    }

    public void AtTheEndOfTheFirstAnimation()
    {
        if (boolean.Chest == true && boolean.firstContorl == true && boolean.Head == true && boolean.RightFoot == true && boolean.RightHand == true && boolean.leftFoot == true)
        {
             print("girdi");
            boolean.CircleTrigger = false;
            boolean.firstContorl = false;
            StartCoroutine(MakeHeartEyeAndAmazingFalse());
            amazingTextGameobje.SetActive(true);
            StartCoroutine(FirstAnimActiveSeconds());
            AnimController.speed = 1;
            WeightClose();
            AnimController.SetBool("FirstAllTriggers", true);
            StartCoroutine(SecondTriggerObjectSecond());
            StartCoroutine(TimeToStartTheSecondAnimation());
            boolean.firstContorl = false;
            boolean.fallAnim = false;
            boolean.RightFoot = false;
            boolean.RightHand = false;
            boolean.leftFoot = false;
            boolean.RightHand = false;
            boolean.leftHand = false;


        }
        else if (boolean.firstContorl == true && (boolean.Head == true || boolean.RightFoot == false || boolean.RightHand == false || boolean.leftFoot == false || boolean.RightHand == false || boolean.leftHand == false))
        {

            boolean.fallAnim = true;
        }
    }
    public void AtTheEndOfTheSecondAnimation()
    {
        if (boolean.secondBoolHead == true && boolean.ChestSecond == true && boolean.secondControl == true && boolean.secondBoolRightFoot == true && boolean.secondBoolRightHand == true && boolean.secondBoolLeftFoot == true && boolean.secondBoolRightHand == true && boolean.secondBoolLeftHand == true)
        {
            havaiFisek.SetActive(true);
            greatTextGameobje.SetActive(true);
            WeightClose();
            boolean.secondBoolfallAnim = true;
            boolean.CircleTrigger = false;
            StartCoroutine(SecondMakeHeartEyeAndAmazingFalse());
            AnimController.SetBool("SecondAllTriggers", true);
            AnimController.speed = 1;
            SecondAnim.SetActive(false);
            secondTriggerObjects.SetActive(false);
            StartCoroutine(NextScene());
            StartCoroutine(SonrakiSahneGecis());
        }
        else if (boolean.secondControl == true)
        {
            boolean.secondBoolfallAnim = false;
        }
    }

    IEnumerator MakeHeartEyeAndAmazingFalse() //KALPLÝ GÖZ VE AMAZÝNG YAZISINI 1.5 SANÝYE SONRA FALSE OLAMSINI SAÐLAYACAK BÖYLECE EKRANDA ÇOK ÇIKMAYACAK
    {
        yield return new WaitForSeconds(1f);
        amazingTextGameobje.SetActive(false);
    }
    IEnumerator SecondMakeHeartEyeAndAmazingFalse() //ÝKÝNCÝ KALPLÝ GÖZ VE AMAZÝNG YAZISINI 1.5 SANÝYE SONRA FALSE OLAMSINI SAÐLAYACAK BÖYLECE EKRANDA ÇOK ÇIKMAYACAK
    {
        yield return new WaitForSeconds(2f);
        greatTextGameobje.SetActive(false);
        yield return new WaitForSeconds(1f);
        youWinTextGameobje.SetActive(true);
    }


    IEnumerator FirstAnimActiveSeconds()
    {
        yield return new WaitForSeconds(0.2f);
        firstAnim.SetActive(false);
        firstTriggerObjects.SetActive(false);
        circle1.SetActive(false);
    }

    void WeightOpen()
    {
        weightHead.GetComponent<MultiAimConstraint>().weight = 1;
        weightRightHand.GetComponent<TwoBoneIKConstraint>().weight = 1;
        weightLeftHand.GetComponent<TwoBoneIKConstraint>().weight = 1;
        weightRightFoot.GetComponent<TwoBoneIKConstraint>().weight = 1;
        weightLeftFoot.GetComponent<TwoBoneIKConstraint>().weight = 1;
        weightChest.GetComponent<TwoBoneIKConstraint>().weight = 1;
    }
    void WeightClose()
    {
        weightHead.GetComponent<MultiAimConstraint>().weight = 0;
        weightRightHand.GetComponent<TwoBoneIKConstraint>().weight = 0;
        weightLeftHand.GetComponent<TwoBoneIKConstraint>().weight = 0;
        weightRightFoot.GetComponent<TwoBoneIKConstraint>().weight = 0;
        weightLeftFoot.GetComponent<TwoBoneIKConstraint>().weight = 0;
        weightChest.GetComponent<TwoBoneIKConstraint>().weight = 0;
    }
    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(b);

    }
    public void StopGame()
    {
        if (oyundurdumu == false)
        {
            Time.timeScale = 0f;
            oyundurdumu = true;
        }
        else
        {
            Time.timeScale = 1f;
            oyundurdumu = false;
        }
    }
    public void TryAgain()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    public void OpenSetting()
    {
        if (oyundurdumu == false)
        {
            settingPlane.SetActive(true);
            Time.timeScale = 0f;
            oyundurdumu = true;
        }
        else
        {
            settingPlane.SetActive(false);
            Time.timeScale = 1f;
            oyundurdumu = false;
        }
    }

    IEnumerator SonrakiSahneGecis()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}