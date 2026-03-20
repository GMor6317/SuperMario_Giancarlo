using UnityEngine;
using Unity.Cinemachine;

public class CambioPantalla : MonoBehaviour
{
    public CinemachineCamera camActual;
    public CinemachineCamera camSiguiente;

    private bool activado = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!activado && other.CompareTag("Player"))
        {
            camActual.Priority = 0;
            camSiguiente.Priority = 10;
            activado = true;
        }
    }
}
