using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DengiVKonce : MonoBehaviour
{
    public static int skok = 0;
    public static int skokDa = 0;
    Text Deffki;
    Text Money;
    Text AllMoney;
    public Slider zavaz;
    Move Movik = new Move();

    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.tag == "SD") Deffki = GetComponent<Text>();
        if (gameObject.tag == "SM") Money = GetComponent<Text>();
        if (gameObject.tag == "SAM") AllMoney = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "SD") //Deffki.text = " " + skok;
        {
            //Deffki.text = DontDestroy.Mon + "$";
            if (Move.skokrazoshibsa2 == 0) Deffki.text = ((skok * (Math.Floor(zavaz.value / Movik.pribavka) + Movik.nadbavka)) + (skokDa * GameObject.Find("Controller").gameObject.GetComponent<Timer>().vziatka)) + "$";
            if (Move.skokrazoshibsa2 == 1) Deffki.text = ((skok * (Math.Floor(zavaz.value / Movik.pribavka) + Movik.nadbavka)) + (skokDa * GameObject.Find("Controller").gameObject.GetComponent<Timer>().vziatka) - 5) + "$";
            if (Move.skokrazoshibsa2 == 2) Deffki.text = ((skok * (Math.Floor(zavaz.value / Movik.pribavka) + Movik.nadbavka)) + (skokDa * GameObject.Find("Controller").gameObject.GetComponent<Timer>().vziatka) - 15) + "$";
            if (Move.skokrazoshibsa2 == 3) Deffki.text = ((skok * (Math.Floor(zavaz.value / Movik.pribavka) + Movik.nadbavka)) + (skokDa * GameObject.Find("Controller").gameObject.GetComponent<Timer>().vziatka) - 30) + "$";
        }
        if (gameObject.tag == "SM")
        {
            if (Move.skokrazoshibsa2 == 0) Money.text = "Кол-во Денег За День: " + ((skok * (Math.Floor(zavaz.value / Movik.pribavka) + Movik.nadbavka)) + (skokDa * GameObject.Find("Controller").gameObject.GetComponent<Timer>().vziatka)) + "$";
            if (Move.skokrazoshibsa2 == 1) Money.text = "Кол-во Денег За День: " + ((skok * (Math.Floor(zavaz.value / Movik.pribavka) + Movik.nadbavka)) + (skokDa * GameObject.Find("Controller").gameObject.GetComponent<Timer>().vziatka) - 5) + "$";
            if (Move.skokrazoshibsa2 == 2) Money.text = "Кол-во Денег За День: " + ((skok * (Math.Floor(zavaz.value / Movik.pribavka) + Movik.nadbavka)) + (skokDa * GameObject.Find("Controller").gameObject.GetComponent<Timer>().vziatka) - 15) + "$";
            if (Move.skokrazoshibsa2 == 3) Money.text = "Кол-во Денег За День: " + ((skok * (Math.Floor(zavaz.value / Movik.pribavka) + Movik.nadbavka)) + (skokDa * GameObject.Find("Controller").gameObject.GetComponent<Timer>().vziatka) - 30) + "$";
        }
        if (gameObject.tag == "SAM")
        {
            if (DontDestroy.Mon >= 0) AllMoney.text = "All money: " + DontDestroy.Mon + "$";
            else AllMoney.text = "Debt: " + (DontDestroy.Mon * -1) + "$";
        }
    }
}
