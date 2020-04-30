using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    public Text DialogB;
    int drop = 0;
    int otv = 0;

    int zapomnil = 100;
    int zapomnil2 = 100;

    GameObject pers;
    public GameObject Receptik;
    public Sprite[] Recepti = new Sprite[2];
    public Text ReceptText;
    public Animator ReceptPanel;
    public bool RecptPanelVkl = true;
    public bool AnadoVkl = false;
    bool docktor = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Move.aga == 1 && drop == 0)
        {
            Frazi();
            pers = GameObject.FindWithTag("Model");
            if (pers.name == "Ber(Clone)")
            {
                var color = DialogB.color;
                color.r = 0.7f;
                color.g = 0.0f;
                color.b = 1.0f;
                DialogB.color = color;
                DialogB.text = "I wanna die! I wanna die! I wanna die! Please kill me!!! Or give me a pack of drugs, then i can get an overdose. If you help me, I give you 300 bucks.";
            }
            if (pers.name == "BW(Clone)")
            {
                var color = DialogB.color;
                color.r = 0.7f;
                color.g = 0.0f;
                color.b = 1.0f;
                DialogB.color = color;
                DialogB.text = "Hello there! Please give me " + ModelsBio.TypeM + ", i will give you for that 200 bucks.";
            }
            if (pers.name == "Nark(Clone)")
            {
                var color = DialogB.color;
                color.r = 0.7f;
                color.g = 0.0f;
                color.b = 1.0f;
                DialogB.color = color;
                DialogB.text = "Hi, I’m conducting an experiment: I grow special plants on preparations - for one of the last experiments I need " + ModelsBio.TypeM + ", do you help me? You can get 20 bucks.";
                //if (DontDestroy.nark == true) DialogB.text = "Привет, ты меня сильно выручил, вот и я в долгу не остнусь.\nВижу тебе не очень хорошо, держи, это поможет.";
            }
            if (pers.name == "TransB(Clone)")
            {
                var color = DialogB.color;
                color.r = 0.7f;
                color.g = 0.0f;
                color.b = 1.0f;
                DialogB.color = color;
                DialogB.text = "I had a hard month, can you give me " + ModelsBio.TypeM + " for relax? Or I'll break all your bones ...";
            }
            if (pers.name == "TryFan(Clone)")
            {
                var color = DialogB.color;
                color.r = 0.7f;
                color.g = 0.0f;
                color.b = 1.0f;
                DialogB.color = color;
                DialogB.text = "Hello colleague, I decided to start a small business at work, for him I need a recipe with a seal, I know you have a suitable one, exchanging it for me for 150 bucks.";
                UFan();
            }
            if (pers.name == "Nark2(Clone)")
            {
                var color = DialogB.color;
                color.r = 0.7f;
                color.g = 0.0f;
                color.b = 1.0f;
                DialogB.color = color;
                DialogB.text = "Hey, good man, I need to get a little buzz, will you help? I just need a dose: " + ModelsBio.TypeM + " - for this you will get a plus in karma."; //for that I can give you as much as $ 20
            }
            drop = 1;
        }
        if (Move.aga == 2)
        {
            var color = DialogB.color;
            color.r = 0.0f;
            color.g = 0.0f;
            color.b = 0.0f;
            DialogB.color = color;
            DialogB.text = "Thanks";
            drop = 0;
            if (otv == 2 && pers.name != "Nark(Clone)" && pers.name != "BW(Clone)" && pers.name != "Nark2(Clone)" && pers.name != "TryFan(Clone)" && pers.name != "TransB(Clone)" && pers.name != "Ber(Clone)")
            {
                DontDestroy.Mon += gameObject.GetComponent<Timer>().vziatka;
                DengiVKonce.skokDa += 1;
                otv = 0;
            }
        }
        if (Move.aga == 3)
        {
            var color = DialogB.color;
            color.r = 0.0f;
            color.b = 0.0f;
            color.g = 0.0f;
            DialogB.color = color;
            DialogB.text = "F@*k you!";
            drop = 0;
        }
        //if (Move.aga == 104)
        //{
        //    var color = DialogB.color;
        //    color.r = 0.7f;
        //    color.g = 0.0f;
        //    color.b = 1.0f;
        //    DialogB.color = color;
        //    DialogB.text = "Привет, ты меня сильно выручил, вот и я в долгу не остнусь.\nВижу тебе не очень хорошо, держи, это поможет.";
        //}
    }

    void Frazi()
    {
        int otvet = 0;
        string[] strArr = new string[4] { "Hi, i need a drug: ", "Give me ", "I will give you $ 10 if you give me ", "This is a pharmacy here? I need " };
        otvet = Random.Range(0, 4);
        if (otvet != zapomnil && otvet != zapomnil2)
        {
            zapomnil2 = zapomnil;
            zapomnil = otvet;

            DialogB.text = strArr[otvet] + ModelsBio.TypeM;
            otv = otvet;

            if (otvet == 2)
            {
                var color = DialogB.color;
                color.r = 0.0f;
                color.b = 0.0f;
                color.g = 0.5f;
                DialogB.color = color;
            }
            else
            {
                var color = DialogB.color;
                color.r = 0.0f;
                color.b = 0.0f;
                color.g = 0.0f;
                DialogB.color = color;
            }
        }
        else Frazi();
    }

    public void UFan()
    {
        if (pers.name == "TryFan(Clone)" || pers.name == "Ber(Clone)")
        {
            if (pers.name == "TryFan(Clone)")
            {
                if (docktor)
                {
                    var color = DialogB.color;
                    color.r = 0.0f;
                    color.g = 0.0f;
                    color.b = 0.0f;
                    DialogB.color = color;
                    DialogB.text = "Yes, I need a prescription, and you need money";
                }
                Receptik.GetComponent<Image>().sprite = Recepti[0];
                ReceptText.text = "Prescription for the purchase of the drug: ";
                ReceptPanenelViehat();
                docktor = true;
            }
            else
            {
                var color = DialogB.color;
                color.r = 0.0f;
                color.g = 0.0f;
                color.b = 0.75f;
                DialogB.color = color;
                DialogB.text = "Do I need f@*king paper to kill myself?! My husband lie to me almost 10 years, I wanna finish with myself!";
            }
        }
        else
        {
            var color = DialogB.color;
            color.r = 0.0f;
            color.g = 0.0f;
            color.b = 0.0f;
            DialogB.color = color;
            for (int i = 0; i < 5; i++)
            {
                if (ModelsBio.Typepreparata == Timer.zadanie[0, i])
                {
                    DialogB.text = ModelsBio.recept[ModelsBio.charectirt1];
                    if (ModelsBio.charectirtO1 == 1)
                    {
                        Receptik.GetComponent<Image>().sprite = Recepti[0];
                        ReceptText.text = "Prescription for the purchase of the drug: " + ModelsBio.TypeM;
                        //RecptPanelVkl = true;
                        ReceptPanenelViehat();
                    }
                    if (ModelsBio.charectirtO1 == 3)
                    {
                        Receptik.GetComponent<Image>().sprite = Recepti[1];
                        ReceptText.text = "Prescription for the purchase of the drug: " + ModelsBio.TypeM;
                        //RecptPanelVkl = true;
                        //AnadoVkl = true;
                        ReceptPanenelViehat();
                    }
                    break;
                }
                else
                {
                    DialogB.text = "To buy this, you do not need it";
                }
            }
        }
    }

    public void ReceptPanenelViehat()
    {
        if (RecptPanelVkl)
        {
            RecptPanelVkl = false;
            ReceptPanel.enabled = true;
            AnadoVkl = true;
            bool ijHidden = ReceptPanel.GetBool("isHidden");
            ReceptPanel.SetBool("isHidden", !ijHidden);
        }
    }

    public void Dosmotrr()
    {
        var color = DialogB.color;
        color.r = 0.0f;
        color.g = 0.0f;
        color.b = 0.0f;
        DialogB.color = color;
        DialogB.text = ModelsBio.dozirovka[ModelsBio.charectirt3];
    }

    public void HowOld()
    {
        var color = DialogB.color;
        color.r = 0.0f;
        color.g = 0.0f;
        color.b = 0.0f;
        DialogB.color = color;
        DialogB.text = ModelsBio.partbilet[ModelsBio.charectirt2];
    }

    public void PovtoriPreparat()
    {
        var color = DialogB.color;
        color.r = 0.0f;
        color.g = 0.0f;
        color.b = 0.0f;
        DialogB.color = color;
        DialogB.text = "I need " + ModelsBio.TypeM;
    }

}
