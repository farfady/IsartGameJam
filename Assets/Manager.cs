using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour
{

    int nbActiveRunners;
    bool runnerLeftActive = true;
    public GameObject[] players;
    int roundNumber = 1;
    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");

        //for (int i = 0; i < players.Length; i++)
        //{
        //    Debug.Log("Player Number " + i + " is named " + players[i].name);
        //}

        AssignLeader();
    }

    private void AssignLeader()
    {
        //players[Random.Range(0, players.Length)].isLeader = true;
    }

    void Update()
    {
        if (players.Length <= 0)
        {
            runnerLeftActive = false;
            EndRound();
        }
        if (roundNumber == players.Length)
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        Debug.Log("End of Game");
        StartCoroutine(ScrollCoroutine());
    }

    IEnumerator ScrollCoroutine()
    {
        yield return new WaitForSeconds(3);    //Wait 3 seconds
        Application.Quit();
    }

    private void EndRound()
    {
        Debug.Log("End of round" + roundNumber);
        roundNumber++;
        throw new System.NotImplementedException();
    }
}
