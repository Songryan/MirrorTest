using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingCrew : MonoBehaviour
{
    public EPlayerColor playerColor;

    // 떠다니는 크루원의 스프라이트와 색상 지정
    private SpriteRenderer spriteRenderer;
    // 날아다니는 방향
    private Vector3 direction;
    // 날아다는 속도
    private float floatingSpeed;
    // 도는 속도
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
        //크기가 큰 크루원이 앞으로 작은 크루원이 뒤로
        spriteRenderer.sortingOrder = (int)Mathf.Lerp(1, 32767f, size);
    }

    void Update()
    {
        transform.position += direction * floatingSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, 0f, rotateSpeed));
    }
}
