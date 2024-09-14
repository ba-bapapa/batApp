using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("�A�E�g�o�[�֘A")]
    [Header("�o�[���オ�肾���J�n�b��")]
    public float changeStart;

    [Header("�o�[�̓��B�X�P�[��")]
    public float changeEnd;

    [Header("�o�[��changeEnd�܂ł̓��B�X�s�[�h")]
    public float changeSpeed;

    [Space(30)]

    [Header("�X�|�[���I�u�W�F�N�g�֘A")]
    [Header("�I�u�W�F�N�g�X�|�[���Ԋu")]
    public float spawnTimer;

    [Header("�I�u�W�F�N�g�̊�{�������x")]
    public float fallingBaseSpeed;

    [Header("�I�u�W�F�N�g�̊�{��]���x")]
    public float rotateBaseSpeed;

    [Header("�I�u�W�F�N�g�̃p�����[�^�[�̕ω��̊J�n����")]
    public float startObjParameterTime;

    [Header("�I�u�W�F�N�g�̕ω���̑����������x")]
    public float fallingSpeed;

    [Header("�I�u�W�F�N�g�̕ω���̑�����]���x")]
    public float rotateSpeed;
}
