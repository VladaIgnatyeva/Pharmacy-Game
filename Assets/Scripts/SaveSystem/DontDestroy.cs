using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DontDestroy : MonoBehaviour
{

    public static float Hp = 100;
    public static float Zav = 1;
    public static double Lek = 0;
    public static double Mon = 0;

    public static float[] Php = {75.0f, 50.0f};
    public static float[] Pzv = { 25.0f, 50.0f };

    public static int zapaud1 = 0;
    public static int zapaud2 = 100;

    //public static bool report1 = false;
    //public static bool report2 = false;
    public static bool mannark = false;
    public static bool psycho = false;
    public static bool nark = false;
    public static bool uberfan = false;
    public static bool pregant = false;
    public static bool busw = false;

    public static bool actII = false;
    public static bool actIII = false;
    public static bool Titri = false;

    public static double[] MonAct = { 0, 0 };
    public static float[] ZavAct = { 1, 1 };
    public static double[] LekAct = { 0, 0 };
    public static float HpAct = 55;
    public static float ZvAct = 25;

    public static bool scenepodgryz = true;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
