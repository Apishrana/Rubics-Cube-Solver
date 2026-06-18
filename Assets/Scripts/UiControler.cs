using UnityEngine;
using UnityEngine.UI;

public class UiControler : MonoBehaviour
{
    [SerializeField] private Button U;
    [SerializeField] private Button U0;
    [SerializeField] private Button D;
    [SerializeField] private Button D0;
    [SerializeField] private Button L;
    [SerializeField] private Button L0;
    [SerializeField] private Button R;
    [SerializeField] private Button R0;
    [SerializeField] private Button F;
    [SerializeField] private Button F0;
    [SerializeField] private Button B;
    [SerializeField] private Button B0;
    [SerializeField] private CubeController CC;
    void Start()
    {
        U.onClick.AddListener(() => { CC.MoveAnimation(FaceName.Up, "U"); });
        U0.onClick.AddListener(() => { CC.MoveAnimation(FaceName.Up, "U'"); });
        D.onClick.AddListener(() => { CC.MoveAnimation(FaceName.Down, "D"); });
        D0.onClick.AddListener(() => { CC.MoveAnimation(FaceName.Down, "D'"); });
        L.onClick.AddListener(() => { CC.MoveAnimation(FaceName.Left, "L"); });
        L0.onClick.AddListener(() => { CC.MoveAnimation(FaceName.Left, "L'"); });
        R.onClick.AddListener(() => { CC.MoveAnimation(FaceName.Right, "R"); });
        R0.onClick.AddListener(() => { CC.MoveAnimation(FaceName.Right, "R'"); });
        F.onClick.AddListener(() => { CC.MoveAnimation(FaceName.Front, "F"); });
        F0.onClick.AddListener(() => { CC.MoveAnimation(FaceName.Front, "F'"); });
        B.onClick.AddListener(() => { CC.MoveAnimation(FaceName.Back, "B"); });
        B0.onClick.AddListener(() => { CC.MoveAnimation(FaceName.Back, "B'"); });
    }
}
