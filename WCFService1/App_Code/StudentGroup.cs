using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for StudentGroup
/// </summary>

[DataContract]
public enum StudentGroup
{
    [EnumMember]
    Maths,

    [EnumMember]
    Science,

    [EnumMember]
    Commerce
}