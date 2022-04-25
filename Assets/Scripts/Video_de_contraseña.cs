using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Video_de_contraseña : MonoBehaviour
{

    string contraseniaCorrecta;
    string contraseniaUsuario; 
    public Text ingresoUsuario;
    public Text textoMsj;
    public GameObject cartelito_mensaje;
    
        // Start is called before the first frame update
    void Start()
    {
        contraseniaCorrecta = "12345";
        cartelito_mensaje.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void validarcontrasenia()
    {
        contraseniaUsuario = ingresoUsuario.text;
        if(contraseniaUsuario == contraseniaCorrecta)
        {
            cartelito_mensaje.SetActive(true);
            textoMsj.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }
        else
        {
            cartelito_mensaje.SetActive(true);
            textoMsj.text = "Contraseña incorrecta";
            Debug.Log("Contraseña incorrecta");
        }
    }
}
