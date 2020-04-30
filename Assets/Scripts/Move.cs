using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Move : MonoBehaviour
{

    public Animator DialogPanel;

    public static int aga = 0;
    int ag1 = 0;
    GameObject model;
    GameObject spa;
    GameObject contrl;

    public Slider zavz;

    public Animator TimePanel1;
    public Animator PanelPlay1;

    public Animator Oshibka;
    public Text OshibkaText;

    public Animator YD;
    public Text YDText;

    public static int skokrazoshibsa = 0;
    public static int skokrazoshibsa2 = 0;

    GameObject pers;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        Move_Bitch();
        if (ag1 == 1)
        {
            model.transform.position = model.transform.position + new Vector3(0.15f, 0);
            if (model.transform.position.x > -4.5f)
            {
                ag1 = 0;
                aga = 1;

                pers = GameObject.FindWithTag("Model");
                if (pers.name == "Nark(Clone)" && DontDestroy.nark == true) Nark_Help();

                DialogPanel.enabled = true;
                bool isHidden = DialogPanel.GetBool("isHidden");
                DialogPanel.SetBool("isHidden", !isHidden);
            }
        }

        if (ag1 == 2)
        {
            model.transform.position = model.transform.position + new Vector3(0.15f, 0);
            if (model.transform.position.x > 15) ag1 = 0;
        }

        if (ag1 == 3)
        {
            model.transform.position = model.transform.position + new Vector3(-0.15f, 0);
            if (model.transform.position.x < -15) ag1 = 0;
        }
    }

    public void Move_Bitch()
    {
        if (aga == 0 && Timer.cho < 1) 
        {
            model = GameObject.FindWithTag("Model");
            Vector2 pos = model.transform.position;
            if (model.transform.position.x < 0) ag1 = 1;
            Timer.last = 1;

            contrl = GameObject.FindWithTag("Control");
            contrl.GetComponent<ModelsBio>().NewM();
        }
    }

    public int nadbavka = 1;
    public int pribavka = 25;
    public int ybivaniprodykcii = 1;

    public void Yeas_Bitch()
    {
        if (aga == 1)
        {
            Vector2 pos = model.transform.position;
            ag1 = 2;
            aga = 2;
            StartCoroutine(SIS());

            pers = GameObject.FindWithTag("Model");
            if (pers.name == "Nark2(Clone)")
            {
                DontDestroy.mannark = true;
                for (int i = 0; i < 5; i++)
                {
                    if (ModelsBio.Typepreparata == Timer.zadanie[0, i])
                    {
                        if (ModelsBio.charectirtO1 == 1)
                        {
                            Story.skokpropdev[Timer.provDen - 1] += 1;
                            DengiVKonce.skok += 1;
                            DontDestroy.Mon += Math.Floor(zavz.value / pribavka) + nadbavka;
                            Timer.zapasi -= ybivaniprodykcii;
                        }
                        else
                        {
                            Timer.zapasi -= ybivaniprodykcii;
                            skokrazoshibsa += 1;
                            skokrazoshibsa2 += 1;
                            if (ModelsBio.charectirtO1 == 3)
                            {
                                if (skokrazoshibsa < 3) OshibkaText.text = "You made a mistake, prescription is fake! This is " + skokrazoshibsa + " mistake - fine: " + skokrazoshibsa * 5 + "$";
                                if (skokrazoshibsa == 3) OshibkaText.text = "You made a mistake, prescription is fake! This is " + skokrazoshibsa + " mistake - fine: " + skokrazoshibsa * 5 + "$, last warning!";
                            }
                            else
                            {
                                if (skokrazoshibsa < 3) OshibkaText.text = "You made a mistake, there was no prescription! This is " + skokrazoshibsa + " mistake - fine: " + skokrazoshibsa * 5 + "$";
                                if (skokrazoshibsa == 3) OshibkaText.text = "You made a mistake, there was no prescription! This is " + skokrazoshibsa + " mistake - fine: " + skokrazoshibsa * 5 + "$, last warning!";
                            }
                            if (skokrazoshibsa == 4) OshibkaText.text = "You made your last mistake, you're fired!";
                            DontDestroy.Mon -= skokrazoshibsa * 5;
                            Oshibsa();
                        }
                        break;
                    }
                    if (ModelsBio.Typepreparata == Timer.zadanie[1, i])
                    {
                        if (ModelsBio.charectirtO2 == 1)
                        {
                            Story.skokpropdev[Timer.provDen - 1] += 1;
                            DengiVKonce.skok += 1;
                            DontDestroy.Mon += Math.Floor(zavz.value / pribavka) + nadbavka;
                            Timer.zapasi -= ybivaniprodykcii;
                        }
                        else
                        {
                            Timer.zapasi -= ybivaniprodykcii;
                            skokrazoshibsa += 1;
                            skokrazoshibsa2 += 1;
                            if (skokrazoshibsa < 3) OshibkaText.text = "You made a mistake, there was no party membership! This is " + skokrazoshibsa + " mistake - fine: " + skokrazoshibsa * 5 + "$";
                            if (skokrazoshibsa == 3) OshibkaText.text = "You made a mistake, there was no party membership! This is " + skokrazoshibsa + " mistake - fine: " + skokrazoshibsa * 5 + "$, last warning!";
                            if (skokrazoshibsa == 4) OshibkaText.text = "You made your last mistake, you're fired!";
                            DontDestroy.Mon -= skokrazoshibsa * 5;
                            Oshibsa();
                        }
                        break;
                    }
                    if (ModelsBio.Typepreparata == Timer.zadanie[2, i])
                    {
                        if (ModelsBio.charectirtO3 == 1)
                        {
                            Story.skokpropdev[Timer.provDen - 1] += 1;
                            DengiVKonce.skok += 1;
                            DontDestroy.Mon += Math.Floor(zavz.value / pribavka) + nadbavka;
                            Timer.zapasi -= ybivaniprodykcii;
                        }
                        else
                        {
                            Timer.zapasi -= ybivaniprodykcii;
                            skokrazoshibsa += 1;
                            skokrazoshibsa2 += 1;
                            if (skokrazoshibsa < 3) OshibkaText.text = "You made a mistake, dosage not observed! This is " + skokrazoshibsa + " mistake - fine: " + skokrazoshibsa * 5 + "$";
                            if (skokrazoshibsa == 3) OshibkaText.text = "You made a mistake, dosage not observed! This is " + skokrazoshibsa + " mistake - fine: " + skokrazoshibsa * 5 + "$, last warning!";
                            if (skokrazoshibsa == 4) OshibkaText.text = "You made your last mistake, you're fired!";
                            DontDestroy.Mon -= skokrazoshibsa * 5;
                            Oshibsa();
                        }
                        break;
                    }
                }
                return;
            }
            if (pers.name == "Nark(Clone)")
            {
                DontDestroy.Mon += 20;
                DengiVKonce.skok += 4;
                DontDestroy.nark = true;
                //DialogPanel.enabled = true;
                //bool isHidden = DialogPanel.GetBool("isHidden");
                //DialogPanel.SetBool("isHidden", !isHidden);
                //DontDestroy.Mon -= 250;
                //if (DontDestroy.Mon < 0) DontDestroy.Mon = 0;
                //aga = 1;
                //No_Bitch();
                //return;
            }
            if (pers.name == "TransB(Clone)")
            {
                DontDestroy.psycho = true;
            }
            if (pers.name == "Ber(Clone)")
            {
                DontDestroy.Mon += 300;
                DengiVKonce.skok += 60;
                DontDestroy.pregant = true;
            }
            if (pers.name == "BW(Clone)")
            {
                DontDestroy.Mon += 200;
                DengiVKonce.skok += 40;
                DontDestroy.busw = true;
                {
                    //for (int i = 0; i < 5; i++)
                    //{
                    //    if (ModelsBio.Typepreparata == Timer.zadanie[0, i])
                    //    {
                    //        Timer.zapasi -= ybivaniprodykcii;
                    //        skokrazoshibsa += 1;
                    //        skokrazoshibsa2 += 1;
                    //        if (skokrazoshibsa < 3) OshibkaText.text = "You made a mistake, there was no prescription! This is " + skokrazoshibsa + " mistake - fine: " + skokrazoshibsa * 5 + "$";
                    //        if (skokrazoshibsa == 3) OshibkaText.text = "You made a mistake, there was no prescription! This is " + skokrazoshibsa + " mistake - fine: " + skokrazoshibsa * 5 + "$, last warning!";
                    //        if (skokrazoshibsa == 4) OshibkaText.text = "You made your last mistake, you're fired!";
                    //        DontDestroy.Mon -= skokrazoshibsa * 5;
                    //        Oshibsa();
                    //        break;
                    //    }
                    //}
                    //return;
                }
            }
            if (pers.name == "TryFan(Clone)")
            {
                DontDestroy.Mon += 150;
                DengiVKonce.skok += 30;
                DontDestroy.uberfan = true;
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    if (ModelsBio.Typepreparata == Timer.zadanie[0, i]) 
                    {
                        if (ModelsBio.charectirtO1 == 1) 
                        {
                            Story.skokpropdev[Timer.provDen - 1] += 1;
                            DengiVKonce.skok += 1;
                            DontDestroy.Mon += Math.Floor(zavz.value / pribavka) + nadbavka;
                            Timer.zapasi -= ybivaniprodykcii;
                        }
                        else
                        {
                            Timer.zapasi -= ybivaniprodykcii;
                            skokrazoshibsa += 1;
                            skokrazoshibsa2 += 1;
                            if (ModelsBio.charectirtO1 == 3)
                            {
                                if (skokrazoshibsa < 3) OshibkaText.text = "You made a mistake, prescription is fake! This is " + skokrazoshibsa + " mistake - fine: " + skokrazoshibsa * 5 + "$";
                                if (skokrazoshibsa == 3) OshibkaText.text = "You made a mistake, prescription is fake! This is " + skokrazoshibsa + " mistake - fine: " + skokrazoshibsa * 5 + "$, last warning!";
                            }
                            else
                            {
                                if (skokrazoshibsa < 3) OshibkaText.text = "You made a mistake, there was no prescription! This is " + skokrazoshibsa + " mistake - fine: " + skokrazoshibsa * 5 + "$";
                                if (skokrazoshibsa == 3) OshibkaText.text = "You made a mistake, there was no prescription! This is " + skokrazoshibsa + " mistake - fine: " + skokrazoshibsa * 5 + "$, last warning!";
                            }
                            if (skokrazoshibsa == 4) OshibkaText.text = "You made your last mistake, you're fired!";
                            DontDestroy.Mon -= skokrazoshibsa * 5;
                            Oshibsa();
                        }
                        break;
                    }
                    if (ModelsBio.Typepreparata == Timer.zadanie[1, i])
                    {
                        if (ModelsBio.charectirtO2 == 1)
                        {
                            Story.skokpropdev[Timer.provDen - 1] += 1;
                            DengiVKonce.skok += 1;
                            DontDestroy.Mon += Math.Floor(zavz.value / pribavka) + nadbavka;
                            Timer.zapasi -= ybivaniprodykcii;
                        }
                        else
                        {
                            Timer.zapasi -= ybivaniprodykcii;
                            skokrazoshibsa += 1;
                            skokrazoshibsa2 += 1;
                            if (skokrazoshibsa < 3) OshibkaText.text = "You made a mistake, there was no party membership! This is " + skokrazoshibsa + " mistake - fine: " + skokrazoshibsa * 5 + "$";
                            if (skokrazoshibsa == 3) OshibkaText.text = "You made a mistake, there was no party membership! This is " + skokrazoshibsa + " mistake - fine: " + skokrazoshibsa * 5 + "$, last warning!";
                            if (skokrazoshibsa == 4) OshibkaText.text = "You made your last mistake, you're fired!";
                            DontDestroy.Mon -= skokrazoshibsa * 5;
                            Oshibsa();
                        }
                        break;
                    }
                    if (ModelsBio.Typepreparata == Timer.zadanie[2, i])
                    {
                        if (ModelsBio.charectirtO3 == 1)
                        {
                            Story.skokpropdev[Timer.provDen - 1] += 1;
                            DengiVKonce.skok += 1;
                            DontDestroy.Mon += Math.Floor(zavz.value / pribavka) + nadbavka;
                            Timer.zapasi -= ybivaniprodykcii;
                        }
                        else
                        {
                            Timer.zapasi -= ybivaniprodykcii;
                            skokrazoshibsa += 1;
                            skokrazoshibsa2 += 1;
                            if (skokrazoshibsa < 3) OshibkaText.text = "You made a mistake, dosage not observed! This is " + skokrazoshibsa + " mistake - fine: " + skokrazoshibsa * 5 + "$";
                            if (skokrazoshibsa == 3) OshibkaText.text = "You made a mistake, dosage not observed! This is " + skokrazoshibsa + " mistake - fine: " + skokrazoshibsa * 5 + "$, last warning!";
                            if (skokrazoshibsa == 4) OshibkaText.text = "You made your last mistake, you're fired!";
                            DontDestroy.Mon -= skokrazoshibsa * 5;
                            Oshibsa();
                        }
                        break;
                    }
                }
            }
            if (skokrazoshibsa == 4) D();
        }
    }

    public void No_Bitch()
    {
        if (aga == 1)
        {
            pers = GameObject.FindWithTag("Model");
            if (pers.name == "TransB(Clone)")
            {
                //gameObject.GetComponent<Timer>().hp.value -= 30;
                //if (gameObject.GetComponent<Timer>().hp.value < 15) gameObject.GetComponent<Timer>().hp.value = 10;
                gameObject.GetComponent<Timer>().TransKill();
                DialogPanel.gameObject.SetActive(false);
            }
            Vector2 pos = model.transform.position;
            ag1 = 3;
            aga = 3;
            if (pers.name == "Nark(Clone)" && DontDestroy.nark == true) aga = 2;
            StartCoroutine(SIS());
        }
    }

    void Oshibsa()
    {
        Oshibka.enabled = true;
        bool isHidden = Oshibka.GetBool("isHidden");
        Oshibka.SetBool("isHidden", !isHidden);
        StartCoroutine(Osh());
    }

    void D()
    {
        PanePlay1();
        YDText.text = "You been fired!";
        YD.enabled = true;
        bool isHidden = YD.GetBool("isHidden");
        YD.SetBool("isHidden", !isHidden);
    }

    public void Nark_Help()
    {
        ag1 = 0;
        aga = 104;

        gameObject.GetComponent<Timer>().hp.value += 35;
        DontDestroy.Mon += 175;
        StartCoroutine(SAS());
    }

    IEnumerator SAS()
    {
        yield return new WaitForSeconds(3.0f);
        DontDestroy.nark = false;
        ag1 = 3;
        DialogPanel.enabled = true;
        bool isHidden = DialogPanel.GetBool("isHidden");
        DialogPanel.SetBool("isHidden", !isHidden);
        yield return new WaitForSeconds(0.75f);
        Destroy(model.gameObject);
        model = GameObject.FindWithTag("Model");
        Destroy(model.gameObject);
        aga = 0;
        ag1 = 0;
        Timer.last = 0;
        Move_Bitch();
    }

    IEnumerator SIS()
    {
        for (int i = 0; i < 5; i++)
        {
            if (ModelsBio.Typepreparata == Timer.zadanie[0, i] && ModelsBio.charectirtO1 != 2)
            {
                if(gameObject.GetComponent<Dialog>().AnadoVkl)
                {
                    gameObject.GetComponent<Dialog>().RecptPanelVkl = true;
                    gameObject.GetComponent<Dialog>().ReceptPanenelViehat();
                }
                break;
            }
        }
        DialogPanel.enabled = true;
        bool isHidden = DialogPanel.GetBool("isHidden");
        DialogPanel.SetBool("isHidden", !isHidden);

        spa = GameObject.FindWithTag("Spa");
        yield return new WaitForSeconds(0.75f);
        Destroy(model.gameObject);
        spa.GetComponent<Spawner>().Clons();
        aga = 0;
        ag1 = 0;
        Timer.last = 0;
        Move_Bitch();
    }

    IEnumerator Osh()
    {
        yield return new WaitForSeconds(3.0f);
        Oshibka.enabled = true;
        bool isHidden = Oshibka.GetBool("isHidden");
        Oshibka.SetBool("isHidden", !isHidden);
    }

    void PanePlay1()
    {
        PanelPlay1.enabled = true;
        bool isHidden = PanelPlay1.GetBool("isHidden");
        PanelPlay1.SetBool("isHidden", !isHidden);

        TimePanel1.enabled = true;
        bool izHidden = TimePanel1.GetBool("isHidden");
        TimePanel1.SetBool("isHidden", !izHidden);
    }

}
