using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public Translations traduccion;

    public Text _textino1;
    public Text _textino2;
    public Text _textino3;
    public Text _textino4;
    // Start is called before the first frame update
    void Start()
    {
        _textino1.text = traduccion.textino1;
        _textino2.text = traduccion.textino2;
        _textino3.text = traduccion.textino3;
        _textino4.text = traduccion.textino4;
    }
}

