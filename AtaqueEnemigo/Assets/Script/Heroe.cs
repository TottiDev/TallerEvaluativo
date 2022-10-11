using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heroe : MonoBehaviour
{

    
    [SerializeField] private int mana;

    public int vidaEnemigo;

    public int casilla;
    
    public GameObject heroe;


    public void Start()
    {
        Debug.Log("La vida del actual del enemigo es " + vidaEnemigo + "\n Tu estamina es de " + mana);
    }
    private void Update()
    {
        heroe = GameObject.Find("Heroe(Clone)");
        
    }

    public void ataqueNormal()
    {

        if (casilla == 0 && mana >= 0) 
        {

            
            Debug.Log("Golpe Normal consume 1 de estamina" + "\n Tu estamina es de " + mana);
            mana = mana - 1;
            vidaEnemigo = vidaEnemigo - 1;
            Debug.Log("Vida Enemigo " + vidaEnemigo);


        }
        else
        {
            Debug.Log("Tienes que estar a una casilla \n para usar el ataque normal.");
        }
        if (vidaEnemigo == 0)
        {
            Debug.Log("Derrotaste al enemigo");
        }
        
    }
    public void ataquMagico()
    {

        if (casilla == 1 && mana >= 0)
        {


            Debug.Log("Golpe Magico consume 2 de estamina" + "\n Tu estamina es de " + mana);
            mana = mana - 2;
            vidaEnemigo = vidaEnemigo - 2;
            Debug.Log("Vida Enemigo " + vidaEnemigo);


        }
        else
        {
            Debug.Log("Tienes que estar dos casilla de distancia \n para usar el ataque magico.");
        }
        if (vidaEnemigo == 0)
        {
            Debug.Log("Derrotaste al enemigo");
        }

    }
    public void adelante()
    {

        heroe.transform.position = new Vector2(2,2);
        casilla = 0;
    }
    public void atras()
    {

        heroe.transform.position = new Vector2(1, 2);
        casilla = 1;
    }
}
