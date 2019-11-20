using UnityEngine;

public class MoveChess : MonoBehaviour
{
    GameObject rook;                            //룩 생성

    void Start()
    {
        rook = GameObject.Find("White Stone Rook");    //룩 게임 오브젝트 초기화
    }

    public void MoveForward()                           //UP 버튼 누르면 실행(버튼의 OnClick())
    {
        rook.transform.Translate(0, 0, 0.2f);              //위 방향으로 1만큼 이동
    }

    public void MoveBackward()                          //Down 버튼 누르면 실행
    {
        rook.transform.Translate(0, 0, -0.2f);             //아래 방향으로 1만큼 이동
    }

    public void MoveLeft()                              //Left 버튼 누르면 실행
    {
        rook.transform.Translate(-0.2f, 0, 0);             //왼쪽 방향으로 1만큼 이동
    }

    public void MoveRight()                             //Right 버튼 누르면 실행
    {
        rook.transform.Translate(0.2f, 0, 0);              //오른쪽 방향으로 1만큼 이동
    }
}
