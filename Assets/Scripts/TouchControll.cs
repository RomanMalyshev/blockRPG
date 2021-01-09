using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchControll : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler {

    public GameFieldPos gameFieldPositions;


    //разница в движении мыши
    float mouseXoldPos;
    float mouseYoldPos;


    //перевод координат мыши в мировае координат камеры
    private Vector3 MouseToWorld = new Vector3();


    public void OnDrag(PointerEventData eventData) {

        MouseToWorld = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 100));

        if ((mouseXoldPos != MouseToWorld.x) || (mouseYoldPos != MouseToWorld.y)) {

            transform.position = new Vector3(transform.position.x + (MouseToWorld.x - mouseXoldPos),
                                             transform.position.y + (MouseToWorld.y - mouseYoldPos),
                                             100);


            mouseXoldPos = MouseToWorld.x;
            mouseYoldPos = MouseToWorld.y;

        }

    }

    public void OnBeginDrag(PointerEventData eventData) {
        Debug.Log("on");

        MouseToWorld = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 100));

        mouseXoldPos = MouseToWorld.x;
        mouseYoldPos = MouseToWorld.y;
    }
    public void OnEndDrag(PointerEventData eventData) {
        Debug.Log("off");
        FigurePosBind(transform.position);
    }


    public void FigurePosBind(Vector3 FigurePos) {
        //Debug.Log(gameFieldPositions.CellsPositions[]);
        Debug.Log(FigurePos);

    }
    
}
