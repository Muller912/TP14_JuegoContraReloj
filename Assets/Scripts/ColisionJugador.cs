using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionJugador : MonoBehaviour
{
    private UIManager uiManager;

    public GameManager gameManager;

    public int hamburguesatotal = 0;

    public int hamburguesasParaGanar = 1;

    void Awake()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Hamburguesa"))
        {
            Destroy(col.gameObject);

            hamburguesatotal++;

            uiManager.UpdateScore(hamburguesatotal);

            if (hamburguesatotal >= hamburguesasParaGanar)
            {
                gameManager.Ganar();
            }
        }
    }
}