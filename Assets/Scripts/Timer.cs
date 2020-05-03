using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Timer : MonoBehaviour
{
    public SpriteRenderer _sprite = null;
    public GameObject threeDObject;
    public GameObject tools;
    public float Speed = 1f;
    public static float timer = 5;//360
    public GameObject contentPanel;
    public GameObject TextPanel;
    public Animator ScorePanel;
    public Animator PanelStat;
    public Animator SmertPanel;
    private DateTime timerEnd;
    public static int cho = 0;
    public static int last = 0;
    Text TimeToLast;
    public Text YHD;
    int kogo = 0;
    public static TimeSpan delta;

    public Toggle Med;
    public Toggle Dru;
    public Toggle Otl;
    public Slider hp;
    public Slider zv;
   
    // для релога дня
    public static double MonBiff = 0;
    public static double LekBiff = 0;
    public static float ZavBiff = 0;
    public static Slider hpbiff;
    public static Slider zvbiff;
    // для релога дня
    
    public GameObject PanDaNet;
    public GameObject knopkaPause;
    
    public static double Lekabuff = 0;
    public static float zavotdeneg;
    public static float zavotdeneg1;
    public static float zavotdeneg2;

    public static float hpbuf;
    public static float zvbuf;

    int provM = 0;
    int provD = 0;
    int provO = 0;
    double lekbuff;
    float zavbuff;

    public static int provDen = 1;
    public static int Den = 1;
    int provDenek = 0;
    int provDenek2 = 0;

    int zapomnil = 100;
    int zapomnil2 = 100;

    bool proWQ = false;

    public float volume;
    public AudioMixer audiomixer;

    public Sprite[] sprites = new Sprite[2];
    public GameObject MusP;

    bool WhMus = true;

    public Text MedSpisok1;
    public Text MedSpisok2;
    public Text MedSpisok3;

    public static int[,] zadanie = new int[3, 5];
    public static string[,] preparati = new string[3, 5];
    public static float zapasi = 100;
    public int vziatka = 10;

    private void Start()
    {
        timerEnd = DateTime.Now.AddSeconds(timer);
        TimeToLast = GetComponent<Text>();

        if (gameObject.tag == "Medicine") Med = GetComponent<Toggle>();
        if (gameObject.tag == "Drug") Dru = GetComponent<Toggle>();

        cho = 10;
        var color = _sprite.color;
        color.a = 1.0f;
        _sprite.color = color;
        PanePlay();
        ////////////////////////////////////////////////
        string lname = SceneManager.GetActiveScene().name;
        if (lname == "Story_Mode")
        {
            gameObject.GetComponent<Story>().DayS();
            if (DontDestroy.actIII == true)
            {
                hp.value = DontDestroy.HpAct;
                zv.value = DontDestroy.ZvAct;
            }
        }
        ////////////////////////////////////////////////
    }

    private void FixedUpdate()
    {
        zavotdeneg1 = hp.value;
        zavotdeneg2 = zv.value;
        if (cho == 0)
        {
            delta = timerEnd - DateTime.Now;
            if (delta.TotalSeconds <= 0)
            {
                Debug.Log("The END");
                cho = 1;
            }
            //gameObject.GetComponent<Sound>().SoundOn();
        }
        if (cho == 1 && last == 0)
        {
            var color = _sprite.color;
            color.a += Speed * Time.deltaTime;
            color.a = Mathf.Clamp(color.a, 0, 1);
            _sprite.color = color;
            threeDObject.SetActive(true);
            tools.SetActive(false);
            if (color.a == 1) cho = 2;

            provM = 0;
            provD = 0;
        }
        if (cho == 2)
        {
            cho = 3;

            if (kogo == 0)
            {
                kogo = 1;
                PanePlay();
                PanelO();
                NextDay();
                //gameObject.GetComponent<Sound>().SoundOff();
            }
        }
        if (cho == 4)
        {
            var color = _sprite.color;
            if (color.a > 0) color.a -= 0.05f;
            _sprite.color = color;
            if (color.a <= 0) cho = 5;
            threeDObject.SetActive(false);
            tools.SetActive(true);
        }
        if (cho == 5)
        {
            var color = _sprite.color;
            color.a = 0.0f;
            _sprite.color = color;
            threeDObject.SetActive(false);
            tools.SetActive(true);
            timerEnd = DateTime.Now.AddSeconds(timer);
            cho = 0;
            kogo = 0;
            DengiVKonce.skok = 0;
            DengiVKonce.skokDa = 0;
            Lekabuff = 0;
        }
        if (Move.skokrazoshibsa == 4)
        {
            cho = 10;
            var color = _sprite.color;
            color.a += Speed * Time.deltaTime;
            color.a = Mathf.Clamp(color.a, 0, 1);
            _sprite.color = color;
            threeDObject.SetActive(true);
            tools.SetActive(false);
        }
    }

    public void TransKill()//плохая концовка из-за пропуска психа-убийцы ебать...
    {
        PanePlay();
        //Vikl();
        YHD.text = "Due to your wrong choice, you been killed by psycho-killer. Have a good afterlife!";
        Animator Deb = SmertPanel;
        Deb.enabled = true;
        bool ijHidden = Deb.GetBool("isHidden");
        Deb.SetBool("isHidden", !ijHidden);
        StartCoroutine(SOS());
    }

    IEnumerator SOS()
    {
        var color = _sprite.color;
        color.a = 0.1f;
        _sprite.color = color;
        yield return new WaitForSeconds(0.1f);
        color.a = 0.2f;
        _sprite.color = color;
        yield return new WaitForSeconds(0.1f);
        color.a = 0.3f;
        _sprite.color = color;
        yield return new WaitForSeconds(0.1f);
        color.a = 0.4f;
        _sprite.color = color;
        yield return new WaitForSeconds(0.1f);
        color.a = 0.5f;
        _sprite.color = color;
        yield return new WaitForSeconds(0.1f);
        color.a = 0.6f;
        _sprite.color = color;
        yield return new WaitForSeconds(0.1f);
        color.a = 0.7f;
        _sprite.color = color;
        yield return new WaitForSeconds(0.1f);
        color.a = 0.8f;
        _sprite.color = color;
        yield return new WaitForSeconds(0.1f);
        color.a = 0.9f;
        _sprite.color = color;
        yield return new WaitForSeconds(0.1f);
        color.a = 1;
        _sprite.color = color;
        threeDObject.SetActive(true);
        tools.SetActive(false);
    }

    bool panelvkl = false;

    public void PanePlay()
    {
        if (panelvkl)
        {
            contentPanel.active = panelvkl;
            TextPanel.active = panelvkl;
            panelvkl = false;
        }
        else
        {
            contentPanel.active = panelvkl;
            TextPanel.active = panelvkl;
            panelvkl = true;
        }
    }

    public void PanelO()
    {
        ScorePanel.enabled = true;
        bool ijHidden = ScorePanel.GetBool("isHidden");
        ScorePanel.SetBool("isHidden", !ijHidden);
    }

    public void PanelSt()
    {
        if (zv.value <= 20)
        {
            YHD.text = "You run out of production and you got fired";
            SmertPanel.enabled = true;
            bool izHidden = SmertPanel.GetBool("isHidden");
            SmertPanel.SetBool("isHidden", !izHidden);
        }
        else
        {
            if (hp.value > 2)
            {
                PanelStat.enabled = true;
                bool isHidden = PanelStat.GetBool("isHidden");
                PanelStat.SetBool("isHidden", !isHidden);
            }
            else
            {
                YHD.text = "You died of loss of health, such things(";
                SmertPanel.enabled = true;
                bool ihHidden = SmertPanel.GetBool("isHidden");
                SmertPanel.SetBool("isHidden", !ihHidden);
            }
        }
    }

    public void Oga()
    {
        cho = 4;
    }

    void NextDay()
    {
        //SmenaMus();
        string lname = SceneManager.GetActiveScene().name;
        if (lname == "Endless_Mode")  Move.skokrazoshibsa = 0;
        lekbuff = Lekabuff;
        zv.value = zapasi;
        hp.value = hp.value - (1.0f + ((100 - hp.value/1.25f) / 2.0f));
        hpbuf = hp.value;
        zvbuf = zv.value;

        Den += 1;
        provDen += 1;
        if (provDenek == 1)
        {
            ViborM();
            Med.GetComponent<Toggle>().isOn = false;
        }
        if (provDenek2 == 1)
        {
            Otl.GetComponent<Toggle>().isOn = false;
        }

        provM = 0;
        provD = 0;
        provO = 0;
        provDenek = 0;
        provDenek2 = 0;
        hp.value = hpbuf;
        zv.value = zvbuf;
        zapasi = zv.value;
    }

    double hpbufik = 0;

    public void ViborM()
    {
        double zakypedi = 100 - hp.value;
        hp.value = hpbuf;
        if (provM == 0)
        {
            provM = 1;
        }
        if (provM == 2)
        {
            hp.value = hpbuf;
            zakypedi = 100 - (int)hp.value;
            DontDestroy.Mon += hpbufik;//zakypedi;
            //hpbufik -= hpbufik; 
            provM = 0;
        }
        if (provM == 1 && DontDestroy.Mon > 2)
        {
            //if (DontDestroy.Mon >= zakypedi)
            //{
            //    hpbufik = zakypedi;
            //    DontDestroy.Mon -= zakypedi;
            //    hp.value = 100;
            //    provM = 2;
            //}
            //else
            //if(DontDestroy.Mon < zakypedi)
            {
                //double skokzakup = Math.Floor(DontDestroy.Mon / 10);
                //hpbufik = skokzakup * 10;
                //DontDestroy.Mon -= skokzakup * 10;
                //hp.value += (float)(skokzakup * 10);
                hpbufik = 0;//DontDestroy.Mon;
                while (DontDestroy.Mon > 0) 
                {
                    if (hp.value >= 100) break;
                    DontDestroy.Mon -= 3;
                    hp.value += 1;
                    hpbufik += 3;
                }
                provM = 2;
            }
            //else Med.GetComponent<Toggle>().isOn = false;
        }
        else Med.GetComponent<Toggle>().isOn = false;
        provDenek = 1;
    }

    double monbufik = 0;

    public void ViborO()//заказ новой партии
    {
        double zakyp = 100 - (int)zv.value;
        zv.value = zvbuf;
        if (provO == 0)
        {
            provO = 1;
        }
        if (provO == 2)
        {
            zv.value = zvbuf;
            zakyp = 100 - (int)zv.value;
            DontDestroy.Mon += monbufik;//zakyp;
            //monbufik -= monbufik;
            provO = 0;
            zapasi = zv.value;
        }
        if (provO == 1 && DontDestroy.Mon > 2)
        {
            //if (DontDestroy.Mon >= zakyp)
            //{
            //    monbufik = zakyp;
            //    DontDestroy.Mon -= zakyp;
            //    zv.value = 100;
            //    provO = 2;
            //    zapasi = zv.value;
            //}
            //else
            //if (DontDestroy.Mon < zakyp)
            {
                //double skokzakup = Math.Floor(DontDestroy.Mon / 10);
                //monbufik = skokzakup * 10;
                //DontDestroy.Mon -= skokzakup * 10;
                //zv.value += (float) (skokzakup * 10);
                //zapasi = zv.value;
                monbufik = 0;// DontDestroy.Mon;
                while (DontDestroy.Mon > 0)
                {
                    if (zv.value >= 100) break;
                    DontDestroy.Mon -= 3;
                    zv.value += 1;
                    monbufik += 3;
                }
                provO = 2;
            }
            //else Otl.GetComponent<Toggle>().isOn = false;
        }
        else Otl.GetComponent<Toggle>().isOn = false;
        provDenek2 = 1;
    }

    public void RazresheniePreparati()
    {
        MedSpisok1.text = "Prescription:";
        MedSpisok2.text = "If a member of the party:";
        MedSpisok3.text = "In dosage";
        int[] bufalo = {16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16 };
        string[] strArr = { "Drenard", "Huflobert", "Tsark", "Ziekvayn", "Achark", "Oslorc", "Chrisbert", "Oitriobey", "Vrumerton", "Zhabas", "Glaifraka", "Megand", "Utrouver", "Meleu", "Mivine" };
        for (int i = 0; i < 15; i ++)
        {
            int ramdompls = UnityEngine.Random.Range(0, 15);
            if (!bufalo.Contains(ramdompls)) { bufalo[i] = ramdompls; }
            else i--;
        }
        for (int j = 0; j < 3; j++)
        {
            for (int i = 0; i < 5; i++)
            {
                zadanie[j, i] = bufalo[(j * 5) + i];
                preparati[j, i] = strArr[bufalo[(j * 5) + i]];
            }

        }
        int randomdoz = UnityEngine.Random.Range(0, 3);
        string[] dozirovchka = new string[3] { "25mg", "70mg", "120mg" };
        MedSpisok3.text += " " + dozirovchka[randomdoz] + ":";
        ModelsBio.whatdozetoday = randomdoz + 1;
        for (int i = 0; i < 5; i++)
        {
            MedSpisok1.text += "\n" + preparati[0, i];
            MedSpisok2.text += "\n" + preparati[1, i];
            MedSpisok3.text += "\n" + preparati[2, i];
        }
    }

    public void MonCash()
    {
        DontDestroy.Lek += Lekabuff;
    }

    public void Podschet()
    {
        zavbuff = DontDestroy.Zav;
        StartCoroutine(SIS());
    }

    IEnumerator SIS()
    {
        yield return new WaitForSeconds(1.0f);
        zavotdeneg = 100 - hp.value;
        DontDestroy.Mon -= zavotdeneg + 10;
    }

    DateTime deltabuff;

    int provaudio = 0;

    public void Sound()
    {
        if (AudioListener.volume == 1)
        {
            AudioListener.volume = 0;
            provaudio = 1;
        }
        else
        {
            AudioListener.volume = 1;
            provaudio = 0;
        }
    }
}
