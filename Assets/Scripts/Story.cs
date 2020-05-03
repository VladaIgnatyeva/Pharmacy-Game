using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Story : MonoBehaviour
{
    public GameObject zavbar;
    public GameObject togg1;
    //public GameObject togg2;
    public GameObject togg3;
    public Animator PerDna;
    public Animator JurPan;
    public Animator NeVipolnilQuestPan;
    public Text KakoiTyr;
    public Text KakoiDen;
    public Text KakoiText;
    public Text KakaiaCel;
    public Text MQNeVipolnen;

    public Sprite[] sprites = new Sprite[4];
    public Sprite[] maps = new Sprite[15];
    public GameObject JurnalP;
    public GameObject StrokaSPodpisu;
    public GameObject spawn;

    public GameObject knopkaDal;
    public GameObject skokdevok;
    public GameObject KakTamDevki;
    int KakovDenMap = 0;
    int zapvibkar = 0;

    int zapomnil = 2;
    int zapomnil2 = 100;
    public static int[] skokpropdev = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

    int Yslovie = 0;
    public static int PersForSujet = 0;
    bool DnevnikVopros = true;

    public GameObject ReceptSpisock;
    public GameObject PartBiletSpisock;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DayS()
    {
        if (DnevnikVopros) PanJA();
        if (DnevnikVopros) JIR();
        //Timer.provDen = 11;
        //gameObject.GetComponent<Timer>().hp.value = 100;
        PlayerPrefs.SetInt("Day", Timer.provDen);
        PlayerPrefs.Save();
        switch (Timer.provDen)
        {
            case 1:
                gameObject.GetComponent<Timer>().hp.value = 100;
                gameObject.GetComponent<Timer>().zv.value = 100;
                Timer.zapasi = 100;
                zavbar.gameObject.SetActive(false);
                togg1.gameObject.SetActive(true);
                togg3.gameObject.SetActive(false);
                ReceptSpisock.gameObject.SetActive(false);
                PartBiletSpisock.gameObject.SetActive(false);
                KakoiDen.text = "Day 1:";
                KakoiText.text = "\t\tWelcome to your new job!\nYou will work as a pharmacist in this state pharmacy.\nBy order of the government dated 07/05/1979, you must sell drugs to people, referring to the allowed dosage.\nIf the client indicates the wrong dosage, you must refuse him.\nHave a good day!";
                
                break;
            case 2:
                Move.skokrazoshibsa2 = 0;
                gameObject.GetComponent<Timer>().zv.value = 100;
                Timer.zapasi = 100;
                KakoiDen.text = "Day 2:";
                KakoiText.text = "\tDue to the rallies near the White House, the conditions for the sale of several drugs have changed: now, in order to buy certain drugs, a person must be in a party.\nAlso new drugs were delivered to the warehouse, check out the list.\nHave a good day!";
                PartBiletSpisock.gameObject.SetActive(true);
                break;
            case 3:
                Move.skokrazoshibsa2 = 0;
                gameObject.GetComponent<Timer>().zv.value = 100;
                Timer.zapasi = 100;
                KakoiDen.text = "Day 3:";
                KakoiText.text = "\tDue to the problems associated with the use of medicines as a drug, the Ministry of Health issued a decree that requires us to require a prescription with a stamp from clients for the sale of certain medicines.\nAlso new drugs were delivered to the warehouse, check out the list.\nHave a good day!";
                ReceptSpisock.gameObject.SetActive(true);
                break;
            case 4:
                Move.skokrazoshibsa = 0;
                Move.skokrazoshibsa2 = 0;
                gameObject.GetComponent<Timer>().zv.value = 100;
                Timer.zapasi = 100;
                zavbar.gameObject.SetActive(true);
                togg3.gameObject.SetActive(true);
                KakoiDen.text = "Day 4:";
                KakoiText.text = "\tThere is a crisis in all states now, so we are forced to reduce the number of our employees.\nFrom this day you must order products for sale yourself.\nAlso, due to the current situation, the list of requirements for drugs has changed, please check out it.\nHave a good day!";
                break;
            case 5:
                Move.skokrazoshibsa2 = 0;
                KakoiDen.text = "Day 5:";
                KakoiText.text = "\tGood afternoon employee! Due to outbreaks of discontent, checks are being carried out throughout the country at workplaces, be careful in your work, they will definitely visit you one day.\nHave a good day!";
                PersForSujet = 22; //старик-наркоман
                Spawner.ocheredforsujet = 0;
                break;
            case 6:
                Move.skokrazoshibsa2 = 0;
                KakoiDen.text = "Day 6";
                KakoiText.text = "\tAnother good day in over country.\nFrom the latest news: there was a mass executions of protesters, but there are good side - unemployment dropped to almost zero! It will not affect your salary...\nHave a good day!";
                PersForSujet = 13; //проверка сверху
                Spawner.ocheredforsujet = 0;
                break;
            case 7:
                Move.skokrazoshibsa2 = 0;
                KakoiDen.text = "Day 7:";
                if (!DontDestroy.busw)
                {
                    KakoiText.text = "\tGood morning! Yesterday the inspector visited you and we can congratulate you - you have passed the \"examination\", you will get 100 bucks as a bonus, keep up the good work.\nHave a good day!";
                    DontDestroy.Mon += 100;
                    Move.skokrazoshibsa = 0;
                }
                else
                {
                    KakoiText.text = "\tGood morning! Yesterday the inspector visited you and we are very disappointed that you did not pass the \"examination\", you’ve been fined 300 bucks for that, please be careful at work or we will be forced to say goodbye to you.\nHave a good day!";
                    DontDestroy.Mon -= 300;
                }
                PersForSujet = 11; //доктор, просящий рецепт для своих дел
                Spawner.ocheredforsujet = 0;
                break;
            case 8:
                Move.skokrazoshibsa = 0;
                Move.skokrazoshibsa2 = 0;
                KakoiDen.text = "Day 8:";
                KakoiText.text = "\tAnother good day in over country.\nDue to the improper distribution of one of the drugs, people grow more aggressive then usually, be careful at work, but also stick to the rules under any conditions.\nHave a good day!";
                PersForSujet = 9; //псих-убийца ебать...
                Spawner.ocheredforsujet = 0;
                break;
            case 9:
                Move.skokrazoshibsa2 = 0;
                KakoiDen.text = "Day 9:";
                KakoiText.text = "\tGood morning!\nYou been good at your job all these days, we noticed it and decided to give you a couple of weekends, you just need to work two more days, then you get your salary and go to weekends.\nHave a good day!";
                PersForSujet = 10; //с(т)ранный мужик который выращивает что-то при помощи препаратов
                Spawner.ocheredforsujet = 0;
                break;
            case 10:
                Move.skokrazoshibsa2 = 0;
                KakoiDen.text = "Day 10:";
                KakoiText.text = "\tGood afternoon employee!\nToday our country selebrate the Big Day - 9 years after Viethnam war end's! Thanks to our 35 president J. Kennedy.\nSo today everyone can get a discount.\nIt will not affect your salary...\nHave a good day!";
                PersForSujet = 12; //какая-то телка, пока непридумал че делает
                Spawner.ocheredforsujet = 0;
                break;
            case 11:
                DontDestroy.Titri = true;
                SceneManager.LoadScene("Koncovki");
                {
                    //KakovDenMap = Timer.provDen;
                    //if (DontDestroy.nark == true && gameObject.GetComponent<Timer>().hp.value <= 30) spawn.GetComponent<Spawner>().SpawnSuj3();
                    //gameObject.GetComponent<Timer>().Quest();
                    //if (DontDestroy.report1 == false) Spawner.ocheredforsujet = 0;
                    //if (DontDestroy.report1 == false) PersForSujet = 8;
                    //Move.skokrazoshibsa = 0;
                    //Timer.Den = 1;
                    //KakoiTyr.text = "Тур \"Средний Запад\"";
                    //KakoiDen.text = "День Первый";
                    //KakoiText.text = "Мне хорошо запомнился последний день прошлого тура. Приходила девушка, просящая денег на лекарство.\n";
                    //if (DontDestroy.nark == true) KakoiText.text += "Я дал в долг странной девушке, даже не знаю зачем. Может я ошибся, вернется ли эта девушка снова?";
                    //else KakoiText.text += "Я прогнал странную девушку, просящую денег в долг. Я нахожусь в такой же ситуации, и собственная жизнь мне дороже. Надеюсь я поступил правильно.";
                    //KakaiaCel.text = ""; //"Моя цель на сегодня:";
                    //DontDestroy.actIII = true;
                    //DontDestroy.MonAct[1] = DontDestroy.Mon;
                    //DontDestroy.LekAct[1] = DontDestroy.Lek;
                    //DontDestroy.ZavAct[1] = DontDestroy.Zav;
                    //DontDestroy.HpAct = gameObject.GetComponent<Timer>().hp.value;
                    //DontDestroy.ZvAct = gameObject.GetComponent<Timer>().zv.value;
                }
                break;
                {
                    //case 12:
                    //    KakovDenMap = Timer.provDen;
                    //    if (DontDestroy.nark == true && gameObject.GetComponent<Timer>().hp.value <= 30) spawn.GetComponent<Spawner>().SpawnSuj3();
                    //    //gameObject.GetComponent<Timer>().Quest();
                    //    Spawner.ocheredforsujet = 0;
                    //    PersForSujet = 11;
                    //    KakoiTyr.text = "Тур \"Средний Запад\"";
                    //    KakoiDen.text = "День Второй";
                    //    //if (DontDestroy.report2 == true && DontDestroy.report1 == false) KakoiText.text = "Вчера снова приходила та журналистка, что предлагала взятку, в этот раз предложив мне еще больше денег. Выбор снова был тяжелым, учитывая мою цель и плохое самочувствие. Но я поступил так, как посчитал правильным.";
                    //    //else KakoiText.text = "Прошлый день тура был был самым обычным, даже скучным, и не особо богатым на события. ";
                    //    KakaiaCel.text = ""; //"Моя цель на сегодня:";
                    //    break;
                    //case 13:
                    //    KakovDenMap = Timer.provDen;
                    //    if (DontDestroy.nark == true && gameObject.GetComponent<Timer>().hp.value <= 30) spawn.GetComponent<Spawner>().SpawnSuj3();
                    //    //gameObject.GetComponent<Timer>().Quest();
                    //    Yslovie = 13;
                    //    Spawner.ocheredforsujet = 0;
                    //    PersForSujet = 12;
                    //    KakoiTyr.text = "Тур \"Средний Запад\"";
                    //    KakoiDen.text = "День Третий";
                    //    KakoiText.text = "Приходила девушка, назвавшая себя \"самая большая на свете фанатка\", и просила ее пропустить.";
                    //    if (DontDestroy.uberfan == true)
                    //    {
                    //        KakoiText.text += "Пропустив ее, я получил штраф, но я не ошибся: она сильно понравилась нашим парням, за что мне вернули деньги и даже дали премию.";
                    //        DontDestroy.Mon += 275;
                    //    }
                    //    else KakoiText.text += "Я не решился пропускать ее, так как она не подходила под требования. Может ей повезет в другой раз, надеюсь она не расстроилась.";
                    //    KakaiaCel.text = ""; //"Моя цель на сегодня:";
                    //    break;
                    //case 14:
                    //    KakovDenMap = Timer.provDen;
                    //    if (DontDestroy.nark == true && gameObject.GetComponent<Timer>().hp.value <= 30) spawn.GetComponent<Spawner>().SpawnSuj3();
                    //    //gameObject.GetComponent<Timer>().Quest();
                    //    Spawner.ocheredforsujet = 0;
                    //    PersForSujet = 13;
                    //    KakoiTyr.text = "Тур \"Средний Запад\"";
                    //    KakoiDen.text = "День Четвертый";
                    //    KakoiText.text = "Вчера произошла очень странная ситуация. Пришедшая девушка убеждала меня, что она беременна от вокалиста группы.\nЯ не пропустил ее - с такими делами пускай она связывается с адвокатом, или обращается к менеджеру.";
                    //    KakaiaCel.text = ""; //"Моя цель на сегодня:";
                    //    //Move.zadanie1 = 1;
                    //    break;
                    //case 15:
                    //    KakovDenMap = Timer.provDen;
                    //    if (DontDestroy.nark == true && gameObject.GetComponent<Timer>().hp.value <= 30) spawn.GetComponent<Spawner>().SpawnSuj3();
                    //    //gameObject.GetComponent<Timer>().Quest();
                    //    KakoiTyr.text = "Тур \"Средний Запад\"";
                    //    KakoiDen.text = "День Пятый";
                    //    KakoiText.text = "Прошедший день был вполне обычным. ";
                    //    if (DontDestroy.uberfan == true) KakoiText.text += "Пропустив пришедшего менеджера я принес огромную пользу группе, за что был премирован. Все были мной довольны.";
                    //    else KakoiText.text += "Разве что пришел менеджер, которого я, на всякий случай, не пропустил. Больше ничего необычного.";
                    //    if (DontDestroy.pregant == true) KakoiText.text = "Прошлый день я польностью пропустил из-за произошедшей ситуации...";
                    //    KakoiText.text += "\nСегодня группа отыгрывает последний день тура, концерт самый крупный из всех, это будет ой как непросто.";
                    //    KakaiaCel.text = ""; //"Моя цель на сегодня:";
                    //    break;
                    //case 16:
                    //    //конец игры
                    //    DontDestroy.Titri = true;
                    //    SceneManager.LoadScene("Koncovki");
                    //    break;
                }
        }
        DnevnikVopros = true;
    }

    void JIR()
    {
        int vibor;
        vibor = UnityEngine.Random.Range(0, 4);
        if (vibor != zapomnil && vibor != zapomnil2)
        {
            zapomnil2 = zapomnil;
            zapomnil = vibor;
            zapvibkar = vibor;
        }
        else JIR();
    }

    public void PanJA()
    {
        JurPan.enabled = true;
        bool ijHidden = JurPan.GetBool("isHidden");
        JurPan.SetBool("isHidden", !ijHidden);
    }

    public void VklPls()
    {
        switch(Timer.provDen)
        {
            case 4:
                zavbar.gameObject.SetActive(true);
                //togg2.gameObject.SetActive(true);
                break;
            case 5:
                togg1.gameObject.SetActive(true);
                break;
            case 8:
                togg3.gameObject.SetActive(true);
                break;
        }
    }

    public void MyQuest()
    {
        switch(Yslovie)
        {
            case 0:
                gameObject.GetComponent<Timer>().Podschet();
                gameObject.GetComponent<Timer>().PanelSt();
                Yslovie = 1;
                break;
            case 1:
                Yslovie = 0;
                DayS();
                break;
            case 4:
                if (DontDestroy.Mon < 25)
                {
                    MQNeVipolnen.text = "Собственное задание проваленно! \n Ты не смог накопить 25$!";
                    Timer.provDen = 4;
                    DontDestroy.Lek = Timer.LekBiff;
                    DontDestroy.Mon = Timer.MonBiff;
                    DontDestroy.Zav = Timer.ZavBiff;
                    gameObject.GetComponent<Timer>().hp = Timer.hpbiff;
                    gameObject.GetComponent<Timer>().zv = Timer.zvbiff;
                    PanMQ();
                }
                else
                {
                    Yslovie = 41;
                    gameObject.GetComponent<Timer>().PanelSt();
                    gameObject.GetComponent<Timer>().hp.value = 95.0f;
                    Timer.hpbuf = gameObject.GetComponent<Timer>().hp.value;                   
                    gameObject.GetComponent<Timer>().Podschet();
                }
                break;
            case 41:
                if (gameObject.GetComponent<Timer>().Dru.isOn == false)
                {
                    MQNeVipolnen.text = "Собственное задание проваленно! \n Ты не купил веществ!";
                    Timer.provDen = 4;
                    DontDestroy.Lek = Timer.LekBiff;
                    DontDestroy.Mon = Timer.MonBiff;
                    DontDestroy.Zav = Timer.ZavBiff;
                    gameObject.GetComponent<Timer>().hp = Timer.hpbiff;
                    gameObject.GetComponent<Timer>().zv = Timer.zvbiff;
                    PanMQ();
                }
                else
                {
                    Yslovie = 0;
                    DayS();
                }
                break;
            case 5:
                if (DontDestroy.Mon < 20)
                {
                    MQNeVipolnen.text = "Собственное задание проваленно! \n Ты не смог накопить 25$!";
                    Timer.provDen = 5;
                    DontDestroy.Lek = Timer.LekBiff;
                    DontDestroy.Mon = Timer.MonBiff;
                    DontDestroy.Zav = Timer.ZavBiff;
                    gameObject.GetComponent<Timer>().hp = Timer.hpbiff;
                    gameObject.GetComponent<Timer>().zv = Timer.zvbiff;
                    PanMQ();
                }
                else
                {
                    Yslovie = 51;
                    gameObject.GetComponent<Timer>().PanelSt();
                    gameObject.GetComponent<Timer>().hp.value = 100.0f;
                    Timer.hpbuf = gameObject.GetComponent<Timer>().hp.value;
                    gameObject.GetComponent<Timer>().Podschet();
                }
                break;
            case 51:
                if (gameObject.GetComponent<Timer>().Med.isOn == false)
                {
                    MQNeVipolnen.text = "Собственное задание проваленно! \n Ты не купил лекарство!";
                    Timer.provDen = 4;
                    DontDestroy.Lek = Timer.LekBiff;
                    DontDestroy.Mon = Timer.MonBiff;
                    DontDestroy.Zav = Timer.ZavBiff;
                    gameObject.GetComponent<Timer>().hp = Timer.hpbiff;
                    gameObject.GetComponent<Timer>().zv = Timer.zvbiff;
                    PanMQ();
                }
                else
                {
                    Yslovie = 0;
                    DayS();
                }
                break;
            case 13:
                if (DontDestroy.pregant == true)
                {
                    DontDestroy.Mon -= 150;
                    gameObject.GetComponent<Timer>().Podschet();
                    gameObject.GetComponent<Timer>().PanelSt();
                    Yslovie = 131;
                }
                else
                {
                    Yslovie = 1;
                    gameObject.GetComponent<Timer>().PanelSt();
                    gameObject.GetComponent<Timer>().Podschet();
                }
                break;
            case 131:
                Yslovie = 0;
                Timer.provDen += 1;
                Timer.Den += 1;
                PerehoDik();
                break;
        }
    }

    public void PanMQ()
    {
        NeVipolnilQuestPan.enabled = true;
        bool ijHidden = NeVipolnilQuestPan.GetBool("isHidden");
        NeVipolnilQuestPan.SetBool("isHidden", !ijHidden);
    }

    public void PerehoDik()
    {
        PerDna.enabled = true;
        bool ijHidden = PerDna.GetBool("isHidden");
        PerDna.SetBool("isHidden", !ijHidden);
    }
}
