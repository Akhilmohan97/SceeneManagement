using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loadmaster : MonoBehaviour
{
    public Button button;
    public string Master;
    void Start()
    {
        button.onClick.AddListener(masterscene);
    }

    void masterscene ()
    {
        SceneManager.LoadScene(Master);

    }
   
}
