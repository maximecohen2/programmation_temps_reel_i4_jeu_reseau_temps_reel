using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public InputField inputFieldKey;

    public string defaultKey;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Connect()
    {
        string key = inputFieldKey.text != "" ? inputFieldKey.text : defaultKey;
        Debug.Log(key);
    }
}
