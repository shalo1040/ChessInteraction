using UnityEngine;

public class RotateChess : MonoBehaviour
{
    Animator anim;                 //애니메이션 객체 생성

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();            //Animator 접근
    }

    public void Rotate()                            //Rotation 버튼 클릭 시 실행
    {
        anim.Play("RotateAnim");                      //RotateAnim 애니메이션 1회 play
        //anim.SetInteger("Rotation", 1);             //Rotation parameter의 값을 1로 설정한다=>무한반복 됨
    }
}
