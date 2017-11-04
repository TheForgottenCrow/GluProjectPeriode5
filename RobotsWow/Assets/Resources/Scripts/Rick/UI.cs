using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{

    public GameObject SplashScreen;
    public GameObject MainMenu;
    public GameObject Settings;
    public GameObject BackgroundFade;
    public GameObject Pauze;
    public GameObject Ingame;
    public GameObject EndScreen;
    private Animator Arnoud;
    int Schermpies;


    // Use this for initialization
    void Start()
    {
        Cases();
        BackgroundFade.SetActive(false);
        Arnoud = BackgroundFade.GetComponent<Animator>();
    }

    //Switch
    private void Update()
    {
        if (Schermpies == 4)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                Schermpies = 3;
                Cases();
            }
        }
    }

    void Cases()
    {

        SplashScreen.SetActive(false);
        MainMenu.SetActive(false);
        Settings.SetActive(false);
        Pauze.SetActive(false);
        Ingame.SetActive(false);
        EndScreen.SetActive(false);

        switch (Schermpies)
        {
            case 0: //Splash screen
                SplashScreen.SetActive(true);
                break;

            case 1: //Main menu
                MainMenu.SetActive(true);
                break;

            case 2: //Settings
                Settings.SetActive(true);
                break;

            case 3: //Pauze
                Pauze.SetActive(true);
                break;

            case 4: //Ingame
                Ingame.SetActive(true);
                break;

            case 5: //End screen
                EndScreen.SetActive(true);
                break;

        }

    }


    //Timer
    IEnumerator Numerator1()
    {
        yield return new WaitForSeconds(1);
        BackgroundFade.SetActive(false);

    }

    IEnumerator Numerator2()
    {

        yield return new WaitForSeconds(30f);
        Schermpies = 4;
        Cases();
        SceneManager.UnloadSceneAsync("Ricky");

    }
    //MainMenu Button
    public void MainMenuB()
    {
        BackgroundFade.SetActive(true);
        Arnoud.SetTrigger("Screenswitch");
        StartCoroutine(Numerator1());
        StartCoroutine(Numerator3());
    }

    //Timer
    IEnumerator Numerator3()
    {

        yield return new WaitForSeconds(0.5f);
        Schermpies = 1;
        Cases();

    }

    // Settingsbutton
    public void SettingsB()
    {
        BackgroundFade.SetActive(true);
        Arnoud.SetTrigger("Screenswitch");
        StartCoroutine(Numerator1());
        StartCoroutine(Numerator4());

    }
    //Timer
    IEnumerator Numerator4()
    {

        yield return new WaitForSeconds(0.5f);
        Schermpies = 2;
        Cases();

    }

    // start button
    public void StartB()
    {
        SceneManager.LoadScene("Ricky", LoadSceneMode.Additive);
        StartCoroutine(Numerator2());
        Schermpies = 4;
        Cases();
    }

    // retry button
    public void RetryB()
    {
        SceneManager.UnloadSceneAsync("Ricky");
        SceneManager.LoadScene("Ricky", LoadSceneMode.Additive);
        StartCoroutine(Numerator2());
        Schermpies = 4;
        Cases();
    }

    // Exit button
    public void ExitB()
    {
        Application.Quit();

    }
}

