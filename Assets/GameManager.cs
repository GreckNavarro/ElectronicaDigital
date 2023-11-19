using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject PanelMenu;
    [SerializeField] GameObject PanelUSerPass;
    [SerializeField] string usuario;
    [SerializeField] string contrase�a;

    [SerializeField] InputField user;
    [SerializeField] InputField inputcontrase�a;

    public void SetUser(string input)
    {
        user.text = input;
    }
    public void SetPassword(string input)
    {
        inputcontrase�a.text = input;
    }

    public void CheckingUser()
    {
        if(user.text == usuario && contrase�a == inputcontrase�a.text)
        {
            Debug.Log("Usuario Ingresado");
            PanelUSerPass.SetActive(false);
            PanelMenu.SetActive(true);
        }
        else
        {
            Debug.Log("Usuario o contrase�a incorrecta");
        }
    }
}
