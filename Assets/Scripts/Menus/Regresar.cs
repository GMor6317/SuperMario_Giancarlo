using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Regresar : MonoBehaviour
{
    //Declarando variables
  private UIDocument menu;
  private Button botonRegresar;

    void OnEnable()
    {
        menu = GetComponent<UIDocument>();  //Obteniendo el documento UI
        var root = menu.rootVisualElement;

        botonRegresar = root.Q<Button>("BotonRegresar");    //Asignando botón y cerrando escena
        botonRegresar.clicked += CerrarEscena;
    }

    private void CerrarEscena() //Función que ayuda a cerrar una escena regresando al menú principal
    {
        SceneManager.LoadScene("EscenaMenu");
    }

    void OnDisable()
    {
        botonRegresar.clicked -= CerrarEscena;
    }
}
