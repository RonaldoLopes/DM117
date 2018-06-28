using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director : MonoBehaviour {

    [SerializeField]
    private GameObject imageGameOver;

    /// <summary>
    /// Congela todo jogo simulando game over
    /// </summary>
	public void EndGame(){

        Time.timeScale = 0;

        imageGameOver.SetActive(true);//ativa a imagem de game over
    }
}
