using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Koncovki : MonoBehaviour
{

    public Animator YourPath;
    public Text YourText;
    public Animator FanPath;
    public Text FanText;
    public Animator BusWPath;
    public Text BusWText;
    public Animator PregPath;
    public Text PregText;
    public GameObject Svet;
    public GameObject PregP;
    public Sprite[] spritesi = new Sprite[2];
    public Animator Nark2Path;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Sound>().SoundOn();
        gameObject.GetComponent<Sound>().KonecSong();
        StartCoroutine(SvetWait());
        YourSelf();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void YourSelf() //концовка ГГ 
    {
        YourText.text = "You worked well and earned a vacation, but what will happen next?";
        if (DontDestroy.busw) YourText.text += "\nDue to your incompetence, the pharmacy management ceased to trust you and you were fired.";
        else YourText.text += "\nSince you passed the \"examination\", you grew up in the eyes of pharmacy management, they even raised your salary and issued benefits.";
        if (DontDestroy.nark) YourText.text += "\nAfter your help to some drug addict, luck began to chase you. Karma?";
        else YourText.text += "\nYou refused to help a sincere person, you began to acquire more unhappy moments in your life. Karma?";
        YourText.text += "\nHave a good day!";

        StartCoroutine(YourWait());
    }

    void Nark()
    { 
        UberFan();
    }

    void UberFan()//
    {
        if (DontDestroy.uberfan) StartCoroutine(FanWait());
        else Psycho();
    }

    void Psycho()//
    {
        StartCoroutine(BuswWait());
    }

    void Nark2()
    {
        if (DontDestroy.mannark) StartCoroutine(Nark2Wait());
        else Preg();
    }

    void Preg()//
    {
        if (DontDestroy.pregant)
        {
            PregP.GetComponent<Image>().sprite = spritesi[0];
            PregText.text = "A sad story happened with a girl who was deceived by her husband.\nAfter her disappearance, she was searched for a long time, but her body was never found.\nIt’s your fault too.";
        }
        else
        {
            PregP.GetComponent<Image>().sprite = spritesi[1];
            PregText.text = "When you refused the girl, in her request to help her with suicide, he thought about it and decided to start life from scratch, you have done well ...\nBut will she be happy this time?";
        }
        StartCoroutine(PregWait());
    }

    IEnumerator YourWait()
    {
        YourPath.enabled = true;
        bool ijHidden = YourPath.GetBool("isHidden");
        YourPath.SetBool("isHidden", !ijHidden);

        yield return new WaitForSeconds(10.0f);

        bool izHidden = YourPath.GetBool("isDa");
        YourPath.SetBool("isDa", !izHidden);

        yield return new WaitForSeconds(1.0f);
        Nark();
    }

    IEnumerator Nark2Wait()
    {
        Nark2Path.enabled = true; // 
        bool ijHidden = Nark2Path.GetBool("isHidden");
        Nark2Path.SetBool("isHidden", !ijHidden); //

        yield return new WaitForSeconds(10.0f);

        bool izHidden = Nark2Path.GetBool("isDa"); //
        Nark2Path.SetBool("isDa", !izHidden); //

        yield return new WaitForSeconds(1.0f);
        Preg();
    }

    IEnumerator FanWait()
    {
        FanPath.enabled = true;
        bool ijHidden = FanPath.GetBool("isHidden");
        FanPath.SetBool("isHidden", !ijHidden);

        yield return new WaitForSeconds(10.0f);

        bool izHidden = FanPath.GetBool("isDa");
        FanPath.SetBool("isDa", !izHidden);

        yield return new WaitForSeconds(1.0f);
        Psycho();
    }

    IEnumerator BuswWait()
    {
        BusWPath.enabled = true;
        bool ijHidden = BusWPath.GetBool("isHidden");
        BusWPath.SetBool("isHidden", !ijHidden);

        yield return new WaitForSeconds(10.0f);

        bool izHidden = BusWPath.GetBool("isDa");
        BusWPath.SetBool("isDa", !izHidden);

        yield return new WaitForSeconds(1.0f);
        Nark2();
    }

    IEnumerator PregWait()
    {
        PregPath.enabled = true;
        bool ijHidden = PregPath.GetBool("isHidden");
        PregPath.SetBool("isHidden", !ijHidden);

        yield return new WaitForSeconds(10.0f);

        bool izHidden = PregPath.GetBool("isDa");
        PregPath.SetBool("isDa", !izHidden);

        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Menu");
    }

    IEnumerator SvetWait()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.05f);
            Svet.SetActive(false);
            yield return new WaitForSeconds(0.05f);
            Svet.SetActive(true);
        }
    }

}
