using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject PanelMenu;
    [SerializeField] GameObject PanelUSerPass;
    [SerializeField] string usuario;
    [SerializeField] string contraseña;

    [SerializeField] InputField user;
    [SerializeField] InputField inputcontraseña;

    public void SetUser(string input)
    {
        user.text = input;
    }
    public void SetPassword(string input)
    {
        inputcontraseña.text = input;
    }

    public void CheckingUser()
    {
        if(user.text == usuario && contraseña == inputcontraseña.text)
        {
            Debug.Log("Usuario Ingresado");
            PanelUSerPass.SetActive(false);
            PanelMenu.SetActive(true);
        }
        else
        {
            Debug.Log("Usuario o contraseña incorrecta");
        }
    }
}
