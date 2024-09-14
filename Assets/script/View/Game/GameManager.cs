using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("バーが上がりだす開始秒数")]
    public float changeStart;

    [Header("バーがどこまで上がるか")]
    public float changeEnd;

    [Header("バーがchangeEndまでの到達スピード")]
    public float changeSpeed;

    [Header("オブジェクトの基本落下速度")]
    public float fallingBaseSpeed;

    [Header("オブジェクトの基本回転速度")]
    public float rotateBaseSpeed;

    [Header("オブジェクトのパラメーターの変化の開始時間")]
    public float startObjParameterTime;

    [Header("オブジェクトの変化後の落下速度")]
    public float fallingSpeed;

    [Header("オブジェクトの変化後の回転速度")]
    public float rotateSpeed;
}
