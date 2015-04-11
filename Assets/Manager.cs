using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour
{

    int nbActiveRunners;
    bool runnerLeftActive = true;
    int MAX_NB_PLAYER = 4;
    public GameObject joueur1,
    joueur2,
    joueur3,
    joueur4;

    void Start()
    {
        AssignLeader();
    }

    private void AssignLeader()
    {
        Random.Range(0, MAX_NB_PLAYER);
    }

    void Update()
    {
        if (nbActiveRunners == 0)
        {
            runnerLeftActive = false;
            EndGame();
        }
    }

    private void EndGame()
    {
        throw new System.NotImplementedException();
    }
}
