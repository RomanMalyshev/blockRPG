using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFieldPos : MonoBehaviour {


    //координаты и размер игрового поля
    public GameObject GameField;
    private Vector3 scaleOfField = new Vector3();
    private Vector3 posOfgield = new Vector3();

    //размер игрового блока 
    public GameObject FigureBlock;
    private Vector3 scaleOfBlock = new Vector3();
    private Vector3 posOfBlock = new Vector3();
    private float BlockWidth;

    //колличество ячеек в строке
    private int CellsInRow = 10;

    private Vector3 startPosCell = new Vector3();
    public Vector3[,] CellsPositions = new Vector3[10,10];//[10,10] изаменить если изменилось количество ячеек в строке


    void Start() {

        //определение координат первой ячейки
        scaleOfField = GameField.GetComponent<Transform>().localScale;
        posOfgield = GameField.GetComponent<Transform>().position;

        FigureBlock.GetComponent<Transform>().localScale = new Vector3(scaleOfField.x *10/ CellsInRow, 0.1f, scaleOfField.z * 10 / CellsInRow);
        scaleOfBlock = FigureBlock.GetComponent<Transform>().localScale;
        posOfBlock = FigureBlock.GetComponent<Transform>().position;
        BlockWidth = scaleOfBlock.x  / 2;

        startPosCell = new Vector3((posOfgield.x - scaleOfField.x * 10 / 2) + BlockWidth, (posOfgield.y - scaleOfField.x * 10 / 2) + BlockWidth, posOfBlock.z);

        //заполнения позиций всех ячеек
        for (int i = 0; i < CellsInRow; i++) {

            float callYpos = startPosCell.y + (BlockWidth*2) * i;

            for (int i2 = 0; i2 < CellsInRow; i2++) {

                CellsPositions[i, i2] = new Vector3(startPosCell.x + (BlockWidth*2) * i2, callYpos, startPosCell.z);
                
                //Instantiate(FigureBlock, CellsPositions[i, i2],Quaternion.Euler(90,180,0));
            }

        }

        //Debug.Log(scaleOfField + " - scaleOfField; " + posOfgield + " - posOfgield; " + scaleOfBlock + " - scaleOfBlock;  " + startPosCell + "  - startPosCell");

    }

}
