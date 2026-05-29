using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionJugador : MonoBehaviour

{
    public int hamburguesatotal = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col){
          if(col.gameObject.CompareTag("Hamburguesa")){
            Destroy(col.gameObject);
            hamburguesatotal = hamburguesatotal + 1;
    }
    }
}
