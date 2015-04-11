using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {

    bool isScrolling = false;
    bool scrollingIsInverted = false;
    Vector3 cameraPosition;
    int COUNTDOWN = 3;
    float speed = 0.2f;


    void Start()
    {
        StartCoroutine(ScrollCoroutine());
    }

    IEnumerator ScrollCoroutine()
    {
        for (int i = 0; i < COUNTDOWN; i++)
        {
            yield return new WaitForSeconds(1);    //Wait one second
            Debug.Log((COUNTDOWN-i).ToString());
        }
        isScrolling = true;
    }

    private void StartScrolling()
    {

        throw new System.NotImplementedException();
    }
	
	// Update is called once per frame
	void Update () {
        if(isScrolling)
        {
            transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
        }
	}
}
