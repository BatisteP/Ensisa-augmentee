using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;
using System.Linq;

public class Navigation : MonoBehaviour, ITrackableEventHandler {
	
    protected TrackableBehaviour mTrackableBehaviour;
    protected TrackableBehaviour.Status m_PreviousStatus;
    protected TrackableBehaviour.Status m_NewStatus;

    private Node associatedNode;

    private bool neighbour = false;

    public GameObject arrow;
    public GameObject end;

    private Vector3 rotate = new Vector3();

    public static bool isNavigating { set; get; }
    private static LinkedList<Node> path = null;
    private static int currentIndex = 0;
    public static Node destination { set; get; }
    private static LinkedList<Node> allNodes = null;

    void Awake() {
        DontDestroyOnLoad(this);
    }

    void Start() {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        if(path==null) {
            path = new LinkedList<Node>();
           currentIndex = 0;
            isNavigating = false;
        }
        associatedNode = new Node(mTrackableBehaviour.name);

        if(allNodes==null) {
            allNodes = new LinkedList<Node>();
        }
        if(!allNodes.Contains(this.associatedNode)) {
            allNodes.AddLast(this.associatedNode);
        }
    }

    void initNeighbour() {
        Node n = null;
        switch (mTrackableBehaviour.name) {
            case "SalleReunion":
                n = searchNode("E30");
                this.associatedNode.AddNeighbour(n);
                break;
            case "E30":
                n = searchNode("E31");
                this.associatedNode.AddNeighbour(n);
                break;
            case "E31":
                n = searchNode("E32");
                this.associatedNode.AddNeighbour(n);
                break;
            case "E32":
                n = searchNode("E33");
                this.associatedNode.AddNeighbour(n);
                n = searchNode("ChercheurMIAM2");
                this.associatedNode.AddNeighbour(n);
                break;
            case "E33":
                n = searchNode("E34");
                this.associatedNode.AddNeighbour(n);
                break;
            case "E34":
                n = searchNode("SecretariatMiage");
                this.associatedNode.AddNeighbour(n);
                break;
            case "SecretariatMiage":
                n = searchNode("E36");
                this.associatedNode.AddNeighbour(n);
                break;
            case "E36":
                n = searchNode("E37");
                this.associatedNode.AddNeighbour(n);
                break;
            case "E37":
                n = searchNode("E37bis");
                this.associatedNode.AddNeighbour(n);
                n = searchNode("IARISS");
                this.associatedNode.AddNeighbour(n);
                break;
            case "E37bis":
                n = searchNode("E38");
                this.associatedNode.AddNeighbour(n);
                break;
            case "ChercheurMIAM3":
                n = searchNode("ChercheurMIAM2");
                this.associatedNode.AddNeighbour(n);
                break;
            case "ChercheurMIAM2":
                n = searchNode("Lauffenburger");
                this.associatedNode.AddNeighbour(n);
                break;
            case "Lauffenburger":
                n = searchNode("BiroucheMourllion");
                this.associatedNode.AddNeighbour(n);
                break;
            case "BiroucheMourllion":
                n = searchNode("Binder");
                this.associatedNode.AddNeighbour(n);
                break;
            case "Binder":
                n = searchNode("Weisser");
                this.associatedNode.AddNeighbour(n);
                break;
            case "Weisser":
                n = searchNode("Ambs");
                this.associatedNode.AddNeighbour(n);
                break;
            case "Ambs":
                n = searchNode("Dupuis");
                this.associatedNode.AddNeighbour(n);
                break;
            case "Dupuis":
                n = searchNode("Orjuela");
                this.associatedNode.AddNeighbour(n);
                break;
            case "Orjuela":
                n = searchNode("Laurain");
                this.associatedNode.AddNeighbour(n);
                break;
            case "Laurain":
                n = searchNode("Basset");
                this.associatedNode.AddNeighbour(n);
                break;
            case "Basset":
                n = searchNode("Ledy");
                this.associatedNode.AddNeighbour(n);
                break;
            case "Ledy":
                n = searchNode("Aubry");
                this.associatedNode.AddNeighbour(n);
                break;
            case "Aubry":
                n = searchNode("ChercheurMIAM1");
                this.associatedNode.AddNeighbour(n);
                break;
            case "IARISS":
                n = searchNode("Labo LSI");
                this.associatedNode.AddNeighbour(n);
                break;
            case "Labo LSI":
                n = searchNode("PCReseaux");
                this.associatedNode.AddNeighbour(n);
                n = searchNode("Perronne");
                this.associatedNode.AddNeighbour(n);
                break;
            case "Perronne":
                n = searchNode("Hassenforder");
                this.associatedNode.AddNeighbour(n);
                break;
            case "Hassenforder":
                n = searchNode("BenSouissi");
                this.associatedNode.AddNeighbour(n);
                break;
            case "BenSouissi":
                n = searchNode("Thiry");
                this.associatedNode.AddNeighbour(n);
                break;
            case "Thiry":
                n = searchNode("Studer");
                this.associatedNode.AddNeighbour(n);
                break;
            case "Studer":
                n = searchNode("Muller");
                this.associatedNode.AddNeighbour(n);
                break;
            case "Muller":
                n = searchNode("Fondement");
                this.associatedNode.AddNeighbour(n);
                break;
            case "Fondement":
                n = searchNode("Pinot");
                this.associatedNode.AddNeighbour(n);
                break;
            case "Pinot":
                n = searchNode("Weber");
                this.associatedNode.AddNeighbour(n);
                break;
            case "Weber":
                n = searchNode("ProfInvite");
                this.associatedNode.AddNeighbour(n);
                break;
            case "ProfInvite":
                n = searchNode("Forestier");
                this.associatedNode.AddNeighbour(n);
                break;
            case "Forestier":
                n = searchNode("LSI");
                this.associatedNode.AddNeighbour(n);
                break;
            case "LSI":
                n = searchNode("ChercheurLSI");
                this.associatedNode.AddNeighbour(n);
                break;
        }
    }

    void Update() {
        if(!neighbour) {
            neighbour = true;
            initNeighbour();
        }
        if(this.end.activeSelf) {
            this.end.transform.Rotate(0, 0, (float)1);
        }
    }

    public static Node searchNode(string name) {
        foreach(Node n in allNodes) {
            if(n.Name == name) {
                return n;
            }
        }
        return null;
    }


    void OnDestroy() {
        if (mTrackableBehaviour)
            mTrackableBehaviour.UnregisterTrackableEventHandler(this);
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus) {
        m_PreviousStatus = previousStatus;
        m_NewStatus = newStatus;

        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED) {
            //Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");
            OnTrackingFound();
        } else if (previousStatus == TrackableBehaviour.Status.TRACKED &&
                   newStatus == TrackableBehaviour.Status.NO_POSE) {
            //Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");
            OnTrackingLost();
        } else {
            OnTrackingLost();
        }
    }

    protected virtual void OnTrackingFound() {
        if(isNavigating) { 
            if(path == null) {
                path = this.associatedNode.HasPathTo(destination.Name,this.associatedNode);
                currentIndex = 0;
                this.end.SetActive(true);
                this.end.transform.position = mTrackableBehaviour.transform.position;
            }
            else if (currentIndex < path.Count && this.associatedNode.Equals(path.ElementAt(currentIndex))) {
                if(currentIndex==path.Count-1) {
                    path = null;
                    isNavigating = false;
                    return;
                }
                string direction = path.ElementAt(currentIndex + 1).GetDirectionFrom(this.associatedNode);
                if(direction.Equals("left")) {
                    rotate.x = -90;
                    arrow.transform.Rotate(rotate);
                } else if(direction.Equals("right")) {
                    rotate.x = 90;
                    arrow.transform.Rotate(rotate);
                } else if(direction.Equals("bottom")) {
                    rotate.x = 0;
                } else {
                    Debug.Log("Error : no path to next node");
                }
                arrow.transform.position = mTrackableBehaviour.transform.position;
                arrow.SetActive(true);
                currentIndex++;
            } else {
                if(path.Contains(this.associatedNode)) {
                    int index = 0;
                    foreach(Node n in path) {
                        if(n == this.associatedNode) {
                            currentIndex = index;
                            break;
                        }
                        index++;
                    }
                } else {
                    path = this.associatedNode.HasPathTo(destination.Name,this.associatedNode);
                    currentIndex = 0;
                }
                OnTrackingFound();
            }
        }
        
    }


    protected virtual void OnTrackingLost() {
        rotate = -rotate;
        this.arrow.transform.Rotate(rotate);
        this.arrow.SetActive(false);
        this.end.SetActive(false);
    }

}
