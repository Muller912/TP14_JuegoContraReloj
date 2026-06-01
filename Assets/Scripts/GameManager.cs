using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float timer = 60f;
    public UIManager uiManager;

    bool juegoTerminado = false;

    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (!juegoTerminado)
        {
            timer -= Time.deltaTime;
            uiManager.UpdateTimer(timer);

            if (timer <= 0)
            {
                juegoTerminado = true;

                uiManager.MostrarPantallaGameOver();

                Time.timeScale = 0;
            }
        }

        if (juegoTerminado && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void Ganar()
    {
        juegoTerminado = true;

        uiManager.MostrarPantallaWin();

        Time.timeScale = 0;
    }
}