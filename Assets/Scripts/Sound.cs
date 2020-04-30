using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Sound : MonoBehaviour
{
    public AudioClip[] treks = new AudioClip[5];
    GameObject ToChtoIgraet;
    GameObject Blya;

    public float volume = 0.25f;
    public AudioMixer audiomixer;

    // Start is called before the first frame update
    void Start()
    {
        string lname = SceneManager.GetActiveScene().name;
        if (lname == "Endless_Mode" || lname == "Story_Mode") 
        {
            ToChtoIgraet = GameObject.Find("DontDestroy(Clone)");
            //ToChtoIgraet.GetComponent<AudioSource>().enabled = false;
            //SoundOff();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RandomSong()
    {
        ToChtoIgraet = GameObject.Find("DontDestroy(Clone)");
        int vibor;
        vibor = UnityEngine.Random.Range(0, 5);
        if (vibor != DontDestroy.zapaud1 && vibor != DontDestroy.zapaud2)
        {
            DontDestroy.zapaud2 = DontDestroy.zapaud1;
            DontDestroy.zapaud1 = vibor;
            ToChtoIgraet.GetComponent<AudioSource>().clip = treks[vibor];
            ToChtoIgraet.GetComponent<AudioSource>().enabled = false;
            ToChtoIgraet.GetComponent<AudioSource>().enabled = true;
        }
        else RandomSong();
    }

    public void MenuSong()
    {
        ToChtoIgraet = GameObject.Find("DontDestroy(Clone)");
        ToChtoIgraet.GetComponent<AudioSource>().clip = treks[0];
        ToChtoIgraet.GetComponent<AudioSource>().enabled = false;
        ToChtoIgraet.GetComponent<AudioSource>().enabled = true;
    }

    public void TitriSong()
    {
        ToChtoIgraet = GameObject.Find("DontDestroy(Clone)");
        ToChtoIgraet.GetComponent<AudioSource>().clip = treks[4];
        ToChtoIgraet.GetComponent<AudioSource>().enabled = false;
        ToChtoIgraet.GetComponent<AudioSource>().enabled = true;
    }

    public void KonecSong()
    {
        ToChtoIgraet = GameObject.Find("DontDestroy(Clone)");
        ToChtoIgraet.GetComponent<AudioSource>().clip = treks[5];
        ToChtoIgraet.GetComponent<AudioSource>().enabled = false;
        ToChtoIgraet.GetComponent<AudioSource>().enabled = true;
    }

    public void SoundOn()
    {
        StartCoroutine(SON());
    }

    public void SoundOff()
    {
        StartCoroutine(SOF());
    }

    IEnumerator SON()
    {
        if (volume < 0.25f)
        {
            yield return new WaitForSeconds(0.25f);

            volume += 0.05f;
            ToChtoIgraet = GameObject.Find("DontDestroy(Clone)");
            ToChtoIgraet.GetComponent<AudioSource>().volume += 0.05f;
            SoundOn();
        }
        else
        {

            Blya = GameObject.Find("MuzForPause");
            Blya.GetComponent<AudioSource>().enabled = false;
            //ToChtoIgraet.GetComponent<AudioSource>().enabled = true;
            volume = 0.25f;
            ToChtoIgraet = GameObject.Find("DontDestroy(Clone)");
            ToChtoIgraet.GetComponent<AudioSource>().volume = 0.25f;
        }
    }

    IEnumerator SOF()
    {
        if (volume > 0.00f)
        {
            yield return new WaitForSeconds(0.25f);

            volume -= 0.05f;
            ToChtoIgraet = GameObject.Find("DontDestroy(Clone)");
            ToChtoIgraet.GetComponent<AudioSource>().volume -= 0.05f;
            SoundOff();
        }
        else
        {
            volume = 0;
            ToChtoIgraet = GameObject.Find("DontDestroy(Clone)");
            ToChtoIgraet.GetComponent<AudioSource>().volume = 0.00f;

            Blya = GameObject.Find("MuzForPause");
            Blya.GetComponent<AudioSource>().enabled = true;
        }
    }
}
