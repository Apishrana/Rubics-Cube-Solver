using System.Collections.Generic;
using UnityEngine;

public class CubeAutomove : MonoBehaviour
{
    private Queue<string> moveQueue = new Queue<string>();
    [SerializeField] private CubeController CC;

    public void PushTOQueue(string move)
    {
        moveQueue.Enqueue(move);
    }
    public void NextMove()
    {
        string move = moveQueue.Dequeue();
        switch (move)
        {
            case "U":
                CC.MoveAnimation(FaceName.Up, "U");
                break;

            case "U'":
                CC.MoveAnimation(FaceName.Up, "U'");
                break;

            case "D":
                CC.MoveAnimation(FaceName.Down, "D");
                break;

            case "D'":
                CC.MoveAnimation(FaceName.Down, "D'");
                break;
            case "L":
                CC.MoveAnimation(FaceName.Left, "L");
                break;

            case "L'":
                CC.MoveAnimation(FaceName.Left, "L'");
                break;

            case "R":
                CC.MoveAnimation(FaceName.Right, "R");
                break;

            case "R'":
                CC.MoveAnimation(FaceName.Right, "R'");
                break;
            case "F":
                CC.MoveAnimation(FaceName.Front, "F");
                break;

            case "F'":
                CC.MoveAnimation(FaceName.Front, "F'");
                break;

            case "B":
                CC.MoveAnimation(FaceName.Back, "B");
                break;

            case "B'":
                CC.MoveAnimation(FaceName.Back, "B'");
                break;

            default:
                Debug.LogWarning("invalid Move");
                break;
        }
        if (moveQueue.Count == 0)
        {
            CC.solving = false;
        }
    }
}
