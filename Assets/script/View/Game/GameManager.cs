using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("�o�[���オ�肾���J�n�b��")]
    public float changeStart;

    [Header("�o�[���ǂ��܂ŏオ�邩")]
    public float changeEnd;

    [Header("�o�[��changeEnd�܂ł̓��B�X�s�[�h")]
    public float changeSpeed;

    [Header("�I�u�W�F�N�g�̊�{�������x")]
    public float fallingBaseSpeed;

    [Header("�I�u�W�F�N�g�̊�{��]���x")]
    public float rotateBaseSpeed;

    [Header("�I�u�W�F�N�g�̃p�����[�^�[�̕ω��̊J�n����")]
    public float startObjParameterTime;

    [Header("�I�u�W�F�N�g�̕ω���̗������x")]
    public float fallingSpeed;

    [Header("�I�u�W�F�N�g�̕ω���̉�]���x")]
    public float rotateSpeed;
}
