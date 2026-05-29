using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float timer = 60f;
    public UIManager uiManager;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (timer > 0)
        {
            timer -= Time.deltaTime; 
            uiManager.UpdateTimer(timer);
        }
    }
}
