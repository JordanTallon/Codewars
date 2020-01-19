/*
My implementation of the A* search algorithm in Unity3D.
Used to solve pathfinding in a dynamic environment

info on the algorithm here https://en.wikipedia.org/wiki/A*_search_algorithm


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AStarPathfinding : MonoBehaviour
{
    Node[,] Grid;
    int roomSize = 50;

    private void Start()
    {
        Grid = new Node[roomSize, roomSize];
        //populate the grid with none null values
        for(int x = 0; x < roomSize; x++)
        {
            for (int y = 0; y < roomSize; y++)
            {
                Grid[x, y] = new Node();
                Grid[x, y].x = x;
                Grid[x, y].y = y;
                //Create a little perlin noise map to test out the algorithm
                Grid[x, y].walkable = Mathf.PerlinNoise(x / 5.0f, y/5.0f) > .3f;
            }
        }

        PathSolve(Grid[24, 0], Grid[roomSize-25, roomSize-1]);
    }

    //placeholder function to visually represent the room / algorithm with unity gizmos
    private void OnDrawGizmos()
    {
        if (Grid != null)
        {
            for (int x = 0; x < roomSize; x++)
            {
                for (int y = 0; y < roomSize; y++)
                {
                    Gizmos.color = Grid[x, y].walkable ? Color.white : Color.red;
                    Gizmos.DrawCube(new Vector3(x, y, 0), new Vector3(.9f, .9f, .9f));
                }
            }
        }
        if(PathNodes != null)
        {
            foreach(Node N in PathNodes)
            {
                Gizmos.color = Color.green;
                Gizmos.DrawCube(new Vector3(N.x, N.y, 0), new Vector3(.9f, .9f, .9f));
            }
        }
    }

    void PathSolve(Node start, Node end)
    {
        List<Node> OpenNodes = new List<Node>();
        List<Node> ClosedNodes = new List<Node>();

        OpenNodes.Add(start);

        while(OpenNodes.Count > 0)
        {
            Node currentNode = LowestFCost(OpenNodes);

            ClosedNodes.Add(currentNode);
            OpenNodes.Remove(currentNode);
            if(currentNode == end)
            {
                RetracePath(end, start);
                print("Path solved");
                //we are done
                break;
            }
    
            foreach(Node N in GetNeighbors(currentNode))
            {
                //If the path has already been added to the closed list or it's an unwalkable surface -continue on, ignoring it.
                if (! N.walkable|| ClosedNodes.Contains(N)) { continue; }

                //If it isn’t on the open list, add it to the open list.       
                if(!OpenNodes.Contains(N))
                {
                    //Make the current square the parent of this square. Record the F, G, and H costs of the square.
                    OpenNodes.Add(N); N.Parent = currentNode;
                    //the gval of the child is equal to the ( parent's gval + the distance to the child ) 
                    //  hval = the child's distance to the ending point of the path
                    N.gVal = currentNode.gVal + NodeDistance(N, currentNode);
                    N.hVal = NodeDistance(N, end);
                }
                else
                {
                    if(N.gVal < currentNode.gVal)
                    {
                        N.Parent = currentNode;
                        N.gVal = currentNode.gVal + NodeDistance(N, currentNode);
                    }
                    else
                    {
                        continue;
                    }
                }

            }
        }
    }

    List<Node> PathNodes = new List<Node>();

    void RetracePath(Node Start, Node End)
    {
        PathNodes = new List<Node>();
        Node currentNode = Start;
        //recursively check children of nodes in the solved path
        //we're looking for the starting node of the whole path
        while (currentNode != End)
        {
            PathNodes.Add(currentNode);
            currentNode = currentNode.Parent;
        }
        PathNodes.Add(End);
        
    }
    public int NodeDistance(Node a, Node b)
    {
        int disX = Mathf.Abs(a.x - b.x);
        int disY = Mathf.Abs(a.y - b.y);
        return (disX + disY);
    }

    List<Node> GetNeighbors(Node baseNode)
    {
        List<Node> Neighbors = new List<Node>();

        /* diagonal neighbors ?
        for(int x = -1; x < 2; x++)
        {
            for (int y = -1; y < 2; y++)
            {
                if(!(x==0 && y==0))
                {
                    try { Neighbors.Add(Grid[baseNode.x + x, baseNode.y+y]); } catch { }
                }
            }
        }*/
        
        //right neighbor
        try { Neighbors.Add(Grid[baseNode.x + 1, baseNode.y]); } catch { }
        //left neighbor
        try { Neighbors.Add(Grid[baseNode.x - 1, baseNode.y]); } catch { }
        //top neighbor
        try { Neighbors.Add(Grid[baseNode.x + 0, baseNode.y + 1]); } catch { }
        //bottom neighbor
        try { Neighbors.Add(Grid[baseNode.x + 0, baseNode.y - 1]); } catch { }

        return (Neighbors);
    }

     Node LowestFCost(List<Node> Nodes)
    {
        int fCost = 42069;
        Node n = null;
        for (int i = 0; i < Nodes.Count; i++)
        {
            if(Nodes[i].fVal < fCost)
            {
                fCost = Nodes[i].fVal;
                n = Nodes[i];
            }
        }
        return (n);
    }
}

public class Node
{
    public int x, y;
    public bool walkable;
    public int hVal;
    public int gVal;
    public int fVal { get { return (hVal + gVal); } }
    public Node Parent;
}
