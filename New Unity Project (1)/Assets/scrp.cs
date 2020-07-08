using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scrp : MonoBehaviour
{
    public Button button;
    public string NewScene;

    private void Start ()
    {
        button.onClick.AddListener(click);

    }
    void click ()
    {
        SceneManager.LoadScene(NewScene);
    }

}
