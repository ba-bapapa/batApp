using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("アウトバー関連")]
    [Header("バーが上がりだす開始秒数")]
    public float changeStartTime;

    [Header("バーの到達スケール")]
    public float changeEndScale;

    [Header("バーの到達スケールまでの到達秒数")]
    public float changeTime;

    [Space(30)]

    [Header("スポーンオブジェクト関連")]
    [Header("オブジェクトスポーン間隔")]
    public float spawnTimer;

    [Header("オブジェクトの基本落下速度")]
    public float fallingBaseSpeed;

    [Header("オブジェクトの基本回転速度")]
    public float rotateBaseSpeed;

    [Header("オブジェクトのパラメーターの変化の開始秒数")]
    public float startObjParameterTime;

    [Header("オブジェクトの変化後の増加落下速度")]
    public float fallingSpeed;

    [Header("オブジェクトの変化後の増加回転速度")]
    public float rotateSpeed;
}
