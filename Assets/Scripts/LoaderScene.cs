using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Coutdown");
    }

    private IEnumerator Coutdown()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("MenuEkrani2");
    }
}
