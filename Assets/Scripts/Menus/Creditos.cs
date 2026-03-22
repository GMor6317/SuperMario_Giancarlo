//Giancarlo Moreno Vázquez
using UnityEngine;
using UnityEngine.UIElements;

public class CreditsScroller : MonoBehaviour
{
    //Declarando variables
    public float speed = 200f;
    private VisualElement credits;
    private float currentY = 0f;

    void OnEnable()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;    //Obteninedo el documento UI
        credits = root.Q<VisualElement>("Creditos");
        
        currentY = Screen.height;   // Empezar desde el fondo de la pantalla
    }

    void Update()
    {
        if (credits != null)
        {
            currentY -= speed * Time.deltaTime; //Si hay créditos, los mueve hacia arriba 
            credits.style.top = currentY;

            if (currentY < -credits.layout.height * 2)  //Si terminaron los créditos, vuelven a empezar de manera automática
            {
                currentY = Screen.height;
            }
        }
    }
}