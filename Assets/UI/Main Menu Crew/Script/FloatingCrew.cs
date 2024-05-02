using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingCrew : MonoBehaviour
{
    public EPlayerColor playerColor;

    // ���ٴϴ� ũ����� ��������Ʈ�� ���� ����
    private SpriteRenderer spriteRenderer;
    // ���ƴٴϴ� ����
    private Vector3 direction;
    // ���ƴٴ� �ӵ�
    private float floatingSpeed;
    // ���� �ӵ�
    private float rotateSpeed;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void SetFloatingCrew(Sprite sprite, EPlayerColor playerColor, Vector3 direction, float floatingSpeed, float rotateSpeed, float size)
    {
        this.playerColor = playerColor;
        this.direction = direction;
        this.floatingSpeed = floatingSpeed;
        this.rotateSpeed = rotateSpeed;

        spriteRenderer.sprite = sprite;
        spriteRenderer.material.SetColor("_PlayerColor",PlayerColor.GetColor(playerColor));

        transform.localScale = new Vector3(size, size, size);
        //ũ�Ⱑ ū ũ����� ������ ���� ũ����� �ڷ�
        spriteRenderer.sortingOrder = (int)Mathf.Lerp(1, 32767f, size);
    }

    void Update()
    {
        transform.position += direction * floatingSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, 0f, rotateSpeed));
    }
}
