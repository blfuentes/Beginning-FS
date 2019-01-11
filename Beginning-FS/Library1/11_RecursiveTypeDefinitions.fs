#if INTERACTIVE
#else
module _11_RecursiveTypeDefinitions
open System.Diagnostics
#endif

// represents an XML attribute
type XmlAttribute =
    {
        AttribName: string;
        AttribValue: string;
    }
// represents an XML element
type XmlElement =
    {
        ElementName: string;
        Attributes: list<XmlAttribute>;
        InnerXml: XmlTree
    }
and XmlTree =
    | Element of XmlElement
    | ElementList of list<XmlTree>
    | Text of string
    | Comment of string
    | Empty
    