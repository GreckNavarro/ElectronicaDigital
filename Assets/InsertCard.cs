using UnityEngine;
using System.IO.Ports;

public class InsertCard : MonoBehaviour
{
    [SerializeField] GameObject PanelMenu;
    [SerializeField] GameObject CurrentPanel;
    
    SerialPort serialPort = new SerialPort("COM6", 9600);

    void Start()
    {
        serialPort.Open();
    }

    // Método que manejará el evento de detección de la carta
    private void OnCardDetected()
    {
        Debug.Log("Carta detectada en Unity");
        PanelMenu.SetActive(true);
        CurrentPanel.SetActive(false);
    }

    void Update()
    {
        if (serialPort.IsOpen && serialPort.BytesToRead > 0)
        {
            try
            {
                string message = serialPort.ReadLine();
                if (message.Contains("NEXT_LEVEL"))
                {
                    OnCardDetected();
                }
            }
            catch (System.Exception)
            {
                Debug.Log("");
            }
        }
    }
    void OnDestroy()
    {
        if (serialPort.IsOpen)
        {
            serialPort.Close();
        }
    }
}
