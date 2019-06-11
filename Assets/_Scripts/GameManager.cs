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
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        bool morreu = jogadorMorreu();
        spawner();

        if (morreu)
        {
            GetComponent<AudioSource>().Stop();
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

    private void spawner()
    {
        if (coolDownTimer > 0) coolDownTimer -= Time.deltaTime;
        else coolDownTimer = 0;

        if (coolDownTimer == 0)
        {
            createBlackHole();
            coolDownTimer = coolDown;
        }
    }
}
