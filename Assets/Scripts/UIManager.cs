using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour

{
    public TextMeshProUGUI texto_score;
    public TextMeshProUGUI texto_timer;
    float tiempo;
    public ColisionJugador ColisionJugador;
    public GameObject winPanel;
    public GameObject gameOverPanel;

    // Start is called before the first frame update
    public void MostrarPantallaWin(){
    winPanel.SetActive(true);
   }

    public void MostrarPantallaGameOver(){
    gameOverPanel.SetActive(true);
   }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        texto_score.text = "Burgas: " + ColisionJugador.hamburguesatotal;

    }
    public void UpdateScore(int currentScore)
    {
        texto_score.text = "Puntaje: " + currentScore;
    }

    public void UpdateTimer(float currentTime){
        texto_timer.text = "Tiempo: " + currentTime.ToString("F0"); 
    }
}
