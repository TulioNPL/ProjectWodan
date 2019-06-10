using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    public GameObject player;
    [SerializeField]
    public GameObject blackHole;
    private float coolDown = 3;
    private float coolDownTimer;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        coolDownTimer = coolDown;
    }

    void Update()
    {
        if (coolDownTimer > 0) coolDownTimer -= Time.deltaTime;
        else coolDownTimer = 0;

        if (coolDownTimer == 0)
        {
            createBlackHole();
            coolDownTimer = coolDown;
        }

        if (jogadorMorreu())
        {
            Debug.Log("Jogador Morreu");
            SceneManager.LoadScene("LoseMenu");
        }
    }

    public bool jogadorMorreu()
    {
        bool morreu = false;
        if (player.transform.position.y < -1) morreu = true;
        return morreu;
    }

    private void createBlackHole()
    {
        Vector3 position = new Vector3(Random.Range(-6.5f, 6.5f), 0, 6.0f);
        Instantiate(blackHole, position, Quaternion.identity);
    }
}
