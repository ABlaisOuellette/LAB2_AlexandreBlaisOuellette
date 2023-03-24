using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Attributs
    [SerializeField] private float _vitesse = 1000;
    private Rigidbody _rb;

    //Méthodes privées
    // Start is called before the first frame update
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        mouvementJoueur();
    }


    //Fonction pour le mouvement du joueur

    private void mouvementJoueur()
    {
        float positionX = Input.GetAxis("Horizontal");
        float positionZ = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(positionX, 0f, positionZ);
        _rb.velocity = direction * Time.deltaTime * _vitesse;        
    }


    //Méthodes publiques

    public void FinPartie()
    {
        this.gameObject.SetActive(false);
    }
}
