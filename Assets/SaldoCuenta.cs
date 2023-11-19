using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaldoCuenta : MonoBehaviour
{
    [SerializeField] int saldoactual;
    [SerializeField] Text textsaldo;
    [SerializeField] InputField retiro;

    void Start()
    {
        textsaldo.text = saldoactual.ToString();
    }

    public void SetRetiro(string i)
    {
        retiro.text = i;
    }

    public void OtherRetiro()
    {
        int currentretiro = int.Parse(retiro.text);
        if(currentretiro > saldoactual)
        {
            Debug.Log("No se puede retirar por falta de saldo");
        }
        else
        {
            SetCurrentSaldo(currentretiro);
        }
        
    }

    public void SetCurrentSaldo(int i)
    {
        if(saldoactual > 0)
        {
            saldoactual = saldoactual - i;
            textsaldo.text = saldoactual.ToString();
        }
        else
        {
            Debug.Log("Saldo Insuficiente");
        }
    }
    public void OtherDepost()
    {
        int currentretiro = int.Parse(retiro.text);
        Depositar(currentretiro);

    }

    public void Set20()
    {
        SetCurrentSaldo(20);
    }
    public void Set50()
    {
        SetCurrentSaldo(50);
    }
    public void Set100()
    {
        SetCurrentSaldo(100);
    }

    public void Depositar(int i)
    {
        saldoactual = saldoactual + i;
        textsaldo.text = saldoactual.ToString();
    }

    public void Depost20()
    {
        Depositar(20);
    }
    public void Depost50()
    {
        Depositar(50);
    }
    public void Depost100()
    {
        Depositar(100);
    }



}
