using UnityEngine;

public class AimCursor : MonoBehaviour
{
    void Update()
    {
        // Pega a posição do mouse na tela e converte para o mundo
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10f; // distância da câmera (ajuste conforme sua cena)
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

        // Atualiza a posição da mira
        transform.position = worldPos;
    }
}