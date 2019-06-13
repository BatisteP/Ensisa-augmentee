using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node {

    public string Name { set; get; }
    private LinkedList<Node> Neighbours {get;}
    private float PosX { set; get; }
    private float PosY { set; get; }
    private char Zone { set; get; }
	
    public Node(string name) {
        this.Name = name;
        this.Neighbours = new LinkedList<Node>();
        this.InitNode();
    }

    public void AddNeighbour(Node n) {
        if(n!=null && !this.Neighbours.Contains(n)) {
            this.Neighbours.AddLast(n);
            n.AddNeighbour(this);
        }
    }

    public LinkedList<Node> HasPathTo(string name, Node callingNode) {
        LinkedList<Node> path = new LinkedList<Node>();
        if(this.Name==name) {
            path.AddFirst(this);
        } else {
            LinkedList<Node> neighbourPath;
            int size = 50;
            foreach(Node n in this.Neighbours) {
                if (n == callingNode) continue;
                neighbourPath = n.HasPathTo(name,this);
                if(neighbourPath.Count>0 && neighbourPath.Count<size) {
                    path = neighbourPath;
                    size = path.Count;
                    path.AddFirst(this);
                }
            }
        }
        return path;
    }

    /*
     *         
        */

    public string GetDirectionFrom(Node from) {
        if (this.Zone.Equals(from.Zone)) {
            if (from.Zone.Equals('A')) {
                float diffY = from.PosY - this.PosY;
                if (diffY > 0) {
                    return "right";
                } else {
                    return "left";
                }
            } else {
                if (this.PosX == from.PosX) {
                    return "bottom";
                } else {
                    float diffX = from.PosX - this.PosX;
                    if (diffX < 0) {
                        if (from.PosY == 0) {
                            return "right";
                        } else {
                            return "left";
                        }
                    } else {
                        if (from.PosY == 0) {
                            return "left";
                        } else {
                            return "right";
                        }
                    }
                }
            }
        } else {
            if (from.Zone.Equals('A')) {
                return "bottom";
            } else {
                if (from.PosY == 0) {
                    return "left";
                } else {
                    return "right";
                }
            }
        }
    }

    public bool Equals(Node n) {
        return this.Name.Equals(n.Name);
    }

    public String ToString() {
        String res = this.Name;
        res += "\n";
        res += this.Neighbours.Count;
        foreach(Node n in this.Neighbours) {
            res += "\n";
            res += n.Name;
        }
        return res;
    }

    private void InitNode() {
        switch (this.Name) {
            case "SalleReunion":
                this.Zone = 'A';
                this.PosX = 0;
                this.PosY = 0;
                break;
            case "E30":
                this.Zone = 'A';
                this.PosX = 0;
                this.PosY = 1;
                break;
            case "E31":
                this.Zone = 'A';
                this.PosX = 0;
                this.PosY = 2;
                break;
            case "E32":
                this.Zone = 'A';
                this.PosX = 0;
                this.PosY = 3;
                break;
            case "E33":
                this.Zone = 'A';
                this.PosX = 0;
                this.PosY = 4;
                break;
            case "E34":
                this.Zone = 'A';
                this.PosX = 0;
                this.PosY = 5;
                break;
            case "SecretariatMiage":
                this.Zone = 'A';
                this.PosX = 0;
                this.PosY = 6;
                break;
            case "E36":
                this.Zone = 'A';
                this.PosX = 0;
                this.PosY = 7;
                break;
            case "E37":
                this.Zone = 'A';
                this.PosX = 0;
                this.PosY = 8;
                break;
            case "E37bis":
                this.Zone = 'A';
                this.PosX = 0;
                this.PosY = 9;
                break;
            case "E38":
                this.Zone = 'A';
                this.PosX = 0;
                this.PosY = 10;
                break;
            case "ChercheurMIAM3":
                this.Zone = 'B';
                this.PosX = 0;
                this.PosY = 1;
                break;
            case "ChercheurMIAM2":
                this.Zone = 'B';
                this.PosX = 0;
                this.PosY = 0;
                break;
            case "Lauffenburger":
                this.Zone = 'B';
                this.PosX = 1;
                this.PosY = 0;
                break;
            case "BiroucheMourllion":
                this.Zone = 'B';
                this.PosX = 2;
                this.PosY = 1;
                break;
            case "Binder":
                this.Zone = 'B';
                this.PosX = 2;
                this.PosY = 0;
                break;
            case "Weisser":
                this.Zone = 'B';
                this.PosX = 3;
                this.PosY = 1;
                break;
            case "Ambs":
                this.Zone = 'B';
                this.PosX = 4;
                this.PosY = 0;
                break;
            case "Dupuis":
                this.Zone = 'B';
                this.PosX = 4;
                this.PosY = 1;
                break;
            case "Orjuela":
                this.Zone = 'B';
                this.PosX = 5;
                this.PosY = 0;
                break;
            case "Laurain":
                this.Zone = 'B';
                this.PosX = 5;
                this.PosY = 1;
                break;
            case "Basset":
                this.Zone = 'B';
                this.PosX = 6;
                this.PosY = 0;
                break;
            case "Ledy":
                this.Zone = 'B';
                this.PosX = 6;
                this.PosY = 1;
                break;
            case "Aubry":
                this.Zone = 'B';
                this.PosX = 7;
                this.PosY = 0;
                break;
            case "ChercheurMIAM1":
                this.Zone = 'B';
                this.PosX = 7;
                this.PosY = 1;
                break;
            case "IARISS":
                this.Zone = 'C';
                this.PosX = 0;
                this.PosY = 1;
                break;
            case "Labo LSI":
                this.Zone = 'C';
                this.PosX = 1;
                this.PosY = 1;
                break;
            case "PCReseaux":
                this.Zone = 'C';
                this.PosX = 1;
                this.PosY = 0;
                break;
            case "Perronne":
                this.Zone = 'C';
                this.PosX = 2;
                this.PosY = 1;
                break;
            case "Hassenforder":
                this.Zone = 'C';
                this.PosX = 3;
                this.PosY = 0;
                break;
            case "BenSouissi":
                this.Zone = 'C';
                this.PosX = 3;
                this.PosY = 1;
                break;
            case "Thiry":
                this.Zone = 'C';
                this.PosX = 4;
                this.PosY = 0;
                break;
            case "Studer":
                this.Zone = 'C';
                this.PosX = 4;
                this.PosY = 1;
                break;
            case "Muller":
                this.Zone = 'C';
                this.PosX = 5;
                this.PosY = 0;
                break;
            case "Fondement":
                this.Zone = 'C';
                this.PosX = 5;
                this.PosY = 1;
                break;
            case "Pinot":
                this.Zone = 'C';
                this.PosX = 6;
                this.PosY = 0;
                break;
            case "Weber":
                this.Zone = 'C';
                this.PosX = 6;
                this.PosY = 1;
                break;
            case "ProfInvite":
                this.Zone = 'C';
                this.PosX = 7;
                this.PosY = 0;
                break;
            case "Forestier":
                this.Zone = 'C';
                this.PosX = 7;
                this.PosY = 1;
                break;
            case "LSI":
                this.Zone = 'C';
                this.PosX = 8;
                this.PosY = 0;
                break;
            case "ChercheurLSI":
                this.Zone = 'C';
                this.PosX = 8;
                this.PosY = 1;
                break;
        }
    }

}
