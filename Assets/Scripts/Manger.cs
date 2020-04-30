using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Manger : MonoBehaviour
{
    GameObject ToChtoIgraet;
    GameObject Blya;

    public GameObject ActTwo;
    public GameObject ActThree;
    public GameObject Titrihi;

    void Start()
    {
        
    }

    public void Story()
    {
        Timer.provDen = 1;//1
        Timer.Den = 1;
        Move.skokrazoshibsa = 0;
        DontDestroy.Mon = 0;
        Move.aga = 0;
        SceneManager.LoadScene("Story_Mode");
    }

    public void Menu()
    {
        Move.aga = 0;
        SceneManager.LoadScene("Menu");
    }

    public void KonecScene()
    {
        DontDestroy.zapaud1 = 5;
        gameObject.GetComponent<Sound>().KonecSong();
        SceneManager.LoadScene("Koncovki");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
