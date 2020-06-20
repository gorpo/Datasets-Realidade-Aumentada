using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class click : MonoBehaviour, Vuforia.IVirtualButtonEventHandler
{

    public GameObject esqueleto1, botao1;

    // Start is called before the first frame update
    void Start()
    {
        botao1 = GameObject.Find("botao1");
        botao1.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        esqueleto1 = GameObject.Find("esqueleto1");
        esqueleto1.SetActive(false);
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        esqueleto1.SetActive(true);
        Debug.Log("BTN Pressed");
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        esqueleto1.SetActive(false);

        Debug.Log("BTN Released");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
