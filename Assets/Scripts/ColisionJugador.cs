using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ColisionJugador : MonoBehaviour
{
    private UIManager uiManager;
    public int hamburguesatotal = 0;

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
            hamburguesatotal = hamburguesatotal + 1;  
            uiManager.UpdateScore(hamburguesatotal);
        }
    }
}