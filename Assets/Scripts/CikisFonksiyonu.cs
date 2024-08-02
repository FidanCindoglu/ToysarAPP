using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CikisFonksiyonu : MonoBehaviour
{
    public void Cikis(){
        Application.Quit();
        Debug.Log("Uygulamadan Cikildi...");
    }
    
}
