
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

[System.Serializable]
public class Game
{
    public static Game current;
    public FirstPersonController control;
    private Vector3 mypos;

    public Game()
    {
        mypos = control.transform.position;

    }
}