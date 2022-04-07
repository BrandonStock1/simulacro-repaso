using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2 : MonoBehaviour
{
    public int prod1;
    public int prod2;
    public int prod3;
    public int monto;

    // Start is called before the first frame update
    void Start()
    {
        int suma;
        int resto;
        suma = (prod1 + prod2 + prod3);
        if (monto > suma)
        {
            Debug.Log("El monto supera la suma de los tres productos");
            resto = (monto - suma);
            Debug.Log("Lo que sobra es " + resto);
        }
        else
        {
            Debug.Log("El monto es menor a la suma de los tres productos");
            resto = (suma - monto);
            Debug.Log("Lo que falta es " + resto);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
