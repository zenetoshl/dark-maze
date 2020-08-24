using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeGenerator : MonoBehaviour {
    //0 - undef
    //1 - up
    //2 - right
    //3 - down
    //4 - left
    public int[, ] maze = new int[20, 20];
    // Start is called before the first frame update
    void Start () {
        GenerateMaze ();
        PrintMaze ();
    }

    private void GenerateMaze () {
        int y = 10;
        int x = 0;

        for (int i = 0; i < 10; i++) {
            while (x < 20) {
                int decision = Random.Range (1, 5);
                if (decision == 1) {
                    if (y >= 1 && maze[x, y - 1] == 0) {
                        y = y - 1;
                    } else {
                        decision++;
                    }
                }

                if (decision == 2) {
                    if (maze[x + 1, y] == 0) {
                        x = x + 1;
                        if( x == 19){
                            maze[x,y] = 6;
                            y = Random.Range (0, 20);
                            x = 0;
                            break;
                        }
                    } else if (y >= 1 && maze[x, y - 1] == 0) {
                        y = y - 1;
                        decision = 1;
                    } else {
                        decision++;
                    }
                }

                if (decision == 3) {
                    if (y <= 19 && maze[x, y + 1] == 0) {
                        y = y + 1;
                    } else if (y >= 1 && maze[x, y - 1] == 0) {
                        y = y - 1;
                        decision = 1;
                    } else
                    if (maze[x + 1, y] == 0) {
                        x = x + 1;
                        decision = 2;
                        if( x == 19){
                            maze[x,y] = 6;
                            y = Random.Range (0, 20);
                            x = 0;
                            break;
                        }
                    } else {
                        decision++;
                    }
                }

                if (decision == 4) {
                    if (x >= 1 && maze[x - 1, y] == 0) {
                        x = x - 1;
                    } else
                    if (y >= 1 && maze[x, y - 1] == 0) {
                        y = y - 1;
                        decision = 1;
                    } else
                    if (maze[x + 1, y] == 0) {
                        x = x + 1;
                        decision = 2;
                        if( x == 19){
                            maze[x,y] = 6;
                            y = Random.Range (0, 20);
                            x = 0;
                            break;
                        }
                    } else
                    if (y <= 18 && maze[x, y + 1] == 0) {
                        y = y + 1;
                        decision = 3;
                    } else {
                        decision++;
                    }
                }
                if (decision == 5) {
                    maze[x, y] = (maze[x, y] == 0) ? decision : maze[x, y];
                    y = Random.Range (0, 20);
                    x = 0;
                    break;
                }
                maze[x, y] = decision;
                

            }
        }
    }

    void PrintMaze () {
        string mazeString = "";
        string line = "";
        for (int i = 0; i < 20; i++) {
            for (int j = 0; j < 20; j++) {
                string letter = " " + maze[j, i];
                line += letter;
            }
            mazeString += line + '\n';
            line = "";
        }
        Debug.Log (mazeString);
    }

    // Update is called once per frame
    void Update () {

    }
}