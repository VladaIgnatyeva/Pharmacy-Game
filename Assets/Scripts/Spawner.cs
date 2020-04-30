using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnLacations;
    public GameObject[] whatToSpawnPrefab;
    public GameObject[] whatToSpawnClone;

    int ocher = 1;
    int zapomnil = 100;
    int zapomnil2 = 100;
    int[] zapom = { 100, 100, 100, 100, 100, 100, 100, 100 };

    public static int ocheredforsujet = 0;

    void Start()
    {
        Clons();
    }

    public void Clons()
    {
        int modwho;
        modwho = UnityEngine.Random.Range(0, 8);//-6
        string lname = SceneManager.GetActiveScene().name;
        if (ocheredforsujet == 1 && lname == "Story_Mode")
        {
            modwho = Story.PersForSujet;
            ocheredforsujet = 10;
        }
        if (modwho != zapom[0] && modwho != zapom[1] && modwho != zapom[2] && modwho != zapom[3] && modwho != zapom[4] && modwho != zapom[5] && modwho != zapom[6])
        {
            zapom[6] = zapom[5];
            zapom[5] = zapom[4];
            zapom[4] = zapom[3];
            zapom[3] = zapom[2];
            zapom[2] = zapom[1];
            zapom[1] = zapom[0];
            zapom[0] = modwho;
            ocheredforsujet += 1;

            switch (modwho)
            {
                case -6:
                    SpawnSAP14(); 
                    break;
                case -5:
                    SpawnSAP13();
                    break;
                case -4:
                    SpawnSAP12();
                    break;
                case -3:
                    SpawnSAP11(); 
                    break;
                case -2:
                    SpawnSAP10(); 
                    break;
                case -1:
                    SpawnSAP9(); 
                    break;
                case 0:
                    SpawnSAP();  
                    break;
                case 1:
                    SpawnSAP2(); 
                    break;
                case 2:
                    SpawnSAP3(); 
                    break;
                case 3:
                    SpawnSAP4(); 
                    break;
                case 4:
                    SpawnSAP5();
                    break;
                case 5:
                    SpawnSAP6(); 
                    break;
                case 6:
                    SpawnSAP7(); 
                    break;
                case 7:
                    SpawnSAP8();
                    break;
                case 8:
                    SpawnSuj1(); // Репортерша
                    break;
                case 9:
                    SpawnSuj2(); // Транс
                    break;
                case 10:
                    SpawnSuj3(); // Наркоша
                    break;
                case 11:
                    SpawnSuj4(); // Убермегафанатка
                    break;
                case 12:
                    SpawnSuj5(); // Беременная
                    break;
                case 13:
                    SpawnSuj6(); // Бизнес телка
                    break;
                case 22:
                    SpawnSuj7(); // Наркоша 2
                    break;
            }
        }
        else Clons();
    }

    IEnumerator SIS()
    {
        yield return new WaitForSeconds(2.15f);
    }

    void SpawnSAP()
    {
        whatToSpawnClone[0] = Instantiate(whatToSpawnPrefab[0], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    void SpawnSAP2()
    {
        whatToSpawnClone[1] = Instantiate(whatToSpawnPrefab[1], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    void SpawnSAP3()
    {
        whatToSpawnClone[2] = Instantiate(whatToSpawnPrefab[2], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    void SpawnSAP4()
    {
        whatToSpawnClone[3] = Instantiate(whatToSpawnPrefab[3], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    void SpawnSAP5()
    {
        whatToSpawnClone[4] = Instantiate(whatToSpawnPrefab[4], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    void SpawnSAP6()
    {
        whatToSpawnClone[5] = Instantiate(whatToSpawnPrefab[5], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    void SpawnSAP7()
    {
        whatToSpawnClone[6] = Instantiate(whatToSpawnPrefab[6], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    void SpawnSAP8()
    {
        whatToSpawnClone[7] = Instantiate(whatToSpawnPrefab[7], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    void SpawnSAP9()
    {
        string lname = SceneManager.GetActiveScene().name;
        if (lname == "Story_Mode") whatToSpawnClone[15] = Instantiate(whatToSpawnPrefab[15], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        if (lname == "Endless_Mode") whatToSpawnClone[8] = Instantiate(whatToSpawnPrefab[8], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    void SpawnSAP10()
    {
        string lname = SceneManager.GetActiveScene().name;
        if (lname == "Story_Mode") whatToSpawnClone[16] = Instantiate(whatToSpawnPrefab[16], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        if (lname == "Endless_Mode") whatToSpawnClone[9] = Instantiate(whatToSpawnPrefab[9], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    void SpawnSAP11()
    {
        string lname = SceneManager.GetActiveScene().name;
        if (lname == "Story_Mode") whatToSpawnClone[17] = Instantiate(whatToSpawnPrefab[17], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        if (lname == "Endless_Mode") whatToSpawnClone[10] = Instantiate(whatToSpawnPrefab[10], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    void SpawnSAP12()
    {
        string lname = SceneManager.GetActiveScene().name;
        if (lname == "Story_Mode") whatToSpawnClone[18] = Instantiate(whatToSpawnPrefab[18], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        if (lname == "Endless_Mode") whatToSpawnClone[11] = Instantiate(whatToSpawnPrefab[11], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    void SpawnSAP13()
    {
        string lname = SceneManager.GetActiveScene().name;
        if (lname == "Story_Mode") whatToSpawnClone[19] = Instantiate(whatToSpawnPrefab[19], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        if (lname == "Endless_Mode") whatToSpawnClone[12] = Instantiate(whatToSpawnPrefab[12], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    void SpawnSAP14()
    {
        string lname = SceneManager.GetActiveScene().name;
        if (lname == "Story_Mode") whatToSpawnClone[20] = Instantiate(whatToSpawnPrefab[20], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        if (lname == "Endless_Mode") whatToSpawnClone[13] = Instantiate(whatToSpawnPrefab[13], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }
    // Для Сюжетки

    public void SpawnSuj1() // Репортерша
    {
        whatToSpawnClone[8] = Instantiate(whatToSpawnPrefab[8], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    public void SpawnSuj2() // Транс
    {
        whatToSpawnClone[9] = Instantiate(whatToSpawnPrefab[9], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    public void SpawnSuj3() // Наркоша
    {
        whatToSpawnClone[10] = Instantiate(whatToSpawnPrefab[10], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    public void SpawnSuj4() // Убермегафанатка
    {
        whatToSpawnClone[11] = Instantiate(whatToSpawnPrefab[11], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    public void SpawnSuj5() // Беременная
    {
        whatToSpawnClone[12] = Instantiate(whatToSpawnPrefab[12], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    public void SpawnSuj6() // Бизнес телка
    {
        whatToSpawnClone[13] = Instantiate(whatToSpawnPrefab[13], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    public void SpawnSuj7() // Наркоша 2
    {
        whatToSpawnClone[14] = Instantiate(whatToSpawnPrefab[14], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }
}
