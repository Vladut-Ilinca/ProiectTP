using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DataController_II : MonoBehaviour
{
    public RoundData_II[] allRoundData;


    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(gameObject);

       SceneManager.LoadScene("Scufita_II");
    }

    public RoundData_II GetCurrentRoundData_II()
    {
        return allRoundData[0];
    }

    // Update is called once per frame
    void Update()
    {

    }
}