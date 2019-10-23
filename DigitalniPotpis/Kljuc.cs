
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class RSAParameters
{

    private string exponentField;

    private string modulusField;

    /// <remarks/>
    public string Exponent
    {
        get
        {
            return this.exponentField;
        }
        set
        {
            this.exponentField = value;
        }
    }

    /// <remarks/>
    public string Modulus
    {
        get
        {
            return this.modulusField;
        }
        set
        {
            this.modulusField = value;
        }
    }
}

