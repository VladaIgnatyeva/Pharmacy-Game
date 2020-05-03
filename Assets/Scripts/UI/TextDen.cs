using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDen : MonoBehaviour
{

    public Text Rashodi;
    public Text OstatoDeneg;
    public Text PerHP;
    public Text PerZV;
    public Text OtlDen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OtlDen.text = "Order medicine: 3$ for 1 medicines"; 
        PerHP.text = Timer.zavotdeneg1 + "%";
        PerZV.text = Timer.zavotdeneg2 + "%";
        Rashodi.text = "Expenses: " + (Timer.zavotdeneg + 10) + "$";
        if (DontDestroy.Mon >= 0) OstatoDeneg.text = "Remaining money: " + DontDestroy.Mon + "$";
        else OstatoDeneg.text = "You are in debt: " + (DontDestroy.Mon * -1) + "$";
    }
}
