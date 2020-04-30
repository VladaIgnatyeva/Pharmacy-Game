using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelsBio : MonoBehaviour
{

    public static string TypeM;
    public static int Typepreparata = 0;
    GameObject Who;
    public int stat = 0;

    public static int charectirt1 = 0;  //указывает на то, какая фраза будет выбранна
    public static int charectirt2 = 0;
    public static int charectirt3 = 0;

    public static int charectirtO1 = 0; //просто аргументы для рассчетов
    public static int charectirtO2 = 0;
    public static int charectirtO3 = 0;

    public static int whatdozetoday = 0;

    public static string[] recept = new string[6] { "I don't have it", "Yeah, here it is", "Well, if you need him so much, take it", "I don't have it, but i have knight...", "Here, but it’s without a seal, but maybe it will come in handy later, you can take it.", "Take it and give me my ticket to KillmyselfLand!" };
    public static string[] partbilet = new string[7] { "I do not belong to any consignment", "I am an honest representative of the Republicans", "I'm from the Democratic Party", "I AM THE HEALER", "I'm starting to lose patience...", "I'm a home scientist-botanist.", "To any of both, just let me die!" };
    public static string[] dozirovka = new string[8] { "I do not know the dosage", "25 milligrams", "70 milligrams", "120 milligrams", "None of your business", "I do not know, but I hope it works anyway...", "Just a couple of ounces, please sell.", "Over 9999 milligrams, please end this!" };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewM()
    {
        Who = GameObject.FindWithTag("Model");
        gameObject.GetComponent<Dialog>().RecptPanelVkl = true;
        gameObject.GetComponent<Dialog>().AnadoVkl = false;
        TypeM = Randompreparat();
        stat = 1;
        if (Who.name == "Nark2(Clone)") stat = 11;  //старик-наркоман
        if (Who.name == "BW(Clone)") stat = 7;      //проверка сверху
        if (Who.name == "TryFan(Clone)") stat = 10; //доктор, просящий рецепт для своих дел
        if (Who.name == "TransB(Clone)") stat = 5;  //Псих-убийца ебать...
        if (Who.name == "Nark(Clone)") stat = 8;    //с(т)ранный мужик который выращивает что-то при помощи препаратов
        if (Who.name == "Ber(Clone)") stat = 6;     //какая-то телка, пока непридумал че делает
        Hz();
    }

    void Hz()
    {
        int ramdompls;
        switch (stat)
        {
            case 1:
                RandomizerCharRecept();     //проверка на рецепт
                RandomizerCharDozirovka();  //проверка на дозировку
                RandomizerCharPartia();     //проверка на партию
                break;
            //Для Сюжетки
            case 5: //Псих-убийца ебать...
                ramdompls = UnityEngine.Random.Range(0, 5);
                Typepreparata = Timer.zadanie[0, ramdompls];
                TypeM = Timer.preparati[0, ramdompls];

                charectirt1 = 3;
                charectirtO1 = 2;

                charectirt2 = 4;
                charectirtO2 = 2;

                charectirt3 = 5;
                charectirtO3 = 2;
                break;
            case 6: //какая-то телка, пока непридумал че делает
                TypeM = "kill myself faster as I can.";

                charectirt1 = 5;
                charectirtO1 = 1;

                charectirt2 = 6;
                charectirtO2 = 1;

                charectirt3 = 7;
                charectirtO3 = 1;
                break;
            case 7: //проверка сверху
                ramdompls = UnityEngine.Random.Range(0, 5);
                Typepreparata = Timer.zadanie[0, ramdompls];
                TypeM = Timer.preparati[0, ramdompls];

                charectirt1 = 0;
                charectirtO1 = 2;

                charectirt2 = 2;
                charectirtO2 = 2;

                charectirt3 = 3;
                charectirtO3 = 2;
                break;
            case 8: //с(т)ранный мужик который выращивает что-то при помощи препаратов
                ramdompls = UnityEngine.Random.Range(0, 5);
                Typepreparata = Timer.zadanie[0, ramdompls];
                TypeM = Timer.preparati[0, ramdompls];

                charectirt1 = 4;
                charectirtO1 = 3;

                charectirt2 = 5;
                charectirtO2 = 2;

                charectirt3 = 6;
                charectirtO3 = 2;
                break;
            case 10: //доктор, просящий рецепт для своих дел
                ramdompls = UnityEngine.Random.Range(0, 5);
                Typepreparata = Timer.zadanie[0, ramdompls];
                TypeM = "prescription";

                charectirt1 = 0;
                charectirtO1 = 3;

                charectirt2 = 3;
                charectirtO2 = 2;

                charectirt3 = 4;
                charectirtO3 = 2;
                break;
            case 11: //старик-наркоман
                charectirt1 = 0;
                charectirtO1 = 2;

                charectirt2 = 0;
                charectirtO2 = 2;

                charectirt3 = 0;
                charectirtO3 = 2;
                break;
        }
        stat = 0;
    }

    void RandomizerCharRecept()
    {
        int firstchar;
        firstchar = Random.Range(0, 3);
        charectirt1 = firstchar;
        if (firstchar == 1)
        {
            charectirtO1 = 1; //можно
        }
        else
        {
            if (firstchar == 2) charectirtO1 = 3; //нельзя но с фейк рецептом
            else charectirtO1 = 2; //нельзя
        }
    }

    void RandomizerCharPartia()
    {
        int firstchar;
        firstchar = Random.Range(0, 3);
        charectirt2 = firstchar;
        if (firstchar != 0)
        {
            charectirtO2 = 1; //можно
        }
        else
        {
            charectirtO2 = 2; //нельзя
        }
    }

    void RandomizerCharDozirovka()
    {
        int firstchar;
        firstchar = Random.Range(0, 4);
        charectirt3 = firstchar;
        if (firstchar != 0 && firstchar == whatdozetoday)
        {
            charectirtO3 = 1; //можно
        }
        else
        {
            charectirtO3 = 2; //нельзя
        }
    }

    string Randompreparat()
    {
        string preparat;
        int ramdompls;
        //Debug.Log(Timer.provDen);
        switch (Timer.provDen)
        {
            case 1:
                ramdompls = UnityEngine.Random.Range(0, 5);
                Typepreparata = Timer.zadanie[2, ramdompls];
                preparat = Timer.preparati[2, ramdompls];
                break;
            case 2:
                ramdompls = UnityEngine.Random.Range(0, 5);
                int ra = UnityEngine.Random.Range(1, 3);
                Typepreparata = Timer.zadanie[ra, ramdompls];
                preparat = Timer.preparati[ra, ramdompls];
                break;
            default:
                string[] strArr = { "Drenard", "Huflobert", "Tsark", "Ziekvayn", "Achark", "Oslorc", "Chrisbert", "Oitriobey", "Vrumerton", "Zhabas", "Glaifraka", "Megand", "Utrouver", "Meleu", "Mivine" };
                ramdompls = UnityEngine.Random.Range(0, 15);
                Typepreparata = ramdompls;
                preparat = strArr[ramdompls];
                break;
        }
        //string[] strArr = { "Drenard", "Huflobert", "Tsark", "Ziekvayn", "Achark", "Oslorc", "Chrisbert", "Oitriobey", "Vrumerton", "Zhabas", "Glaifraka", "Megand", "Utrouver", "Meleu", "Mivine" };
        //int ramdompls = UnityEngine.Random.Range(0, 15);
        //Typepreparata = ramdompls;
        //preparat = strArr[ramdompls];
        return preparat;
    }
}
