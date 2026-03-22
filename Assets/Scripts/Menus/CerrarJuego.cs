//Giancarlo Moreno Vázquez
using UnityEngine;
using UnityEngine.UIElements;

public class CerrarJuego : MonoBehaviour
{
    //Declarando variables
    private UIDocument menu;
    private Button MbotonCerrar;
    private Button AbotonCerrar;

    void OnEnable()
    {
        menu = GetComponent<UIDocument>();  //Obteniendo el documento UI
        var root = menu.rootVisualElement;

        MbotonCerrar = root.Q<Button>("BotonCerrarM");  //Asignando funcionalidad al boton para cerrar el juego cuando es presionado 
        MbotonCerrar.clicked += CierreJuego;
        
        AbotonCerrar = root.Q<Button>("BotonCerrarA");
        AbotonCerrar.clicked += CierreJuego;
    }

    private void CierreJuego()  //Función que ayuda a cerrar el juego 
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
