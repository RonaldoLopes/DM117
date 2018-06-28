using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour {

    [SerializeField]
    private float forca = 5f;

    private Director diretor;

    Rigidbody2D impulse;


    /// <summary>
    /// Metodo chamado pela unity assim que for criados
    /// </summary>
    private void Awake(){
        impulse = this.GetComponent<Rigidbody2D>();
        diretor = GameObject.FindObjectOfType<Director>();//procura o objeto do tipo Diretor na scene e retorna
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetButtonDown("Fire1")) {
            Subir();
        }
	}
    /// <summary>
    /// Adiciona uma impulsão ao objeto, pega a fisica do objeto e adiciona força
    /// </summary>
    private void Subir(){

        impulse.velocity = Vector2.zero;//anula a força do click
        impulse.AddForce(Vector2.up * forca, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision){
        impulse.simulated = false; //desabilita fisica
        diretor.EndGame();
    }
}
