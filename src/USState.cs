using Intellenum;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Enums.States.US;

/// <summary>
/// A  simple, standardized enum representing all U.S. states and territories using their two-letter postal abbreviations. Ideal for validation, storage, and display logic in location-based applications.
/// </summary>
[PublicOpenApiObject]
[Intellenum<string>]
public partial class USState
{
    /// <summary>Alabama</summary>
    public static readonly USState AL = new("AL");

    /// <summary>Alaska</summary>
    public static readonly USState AK = new("AK");

    /// <summary>Arizona</summary>
    public static readonly USState AZ = new("AZ");

    /// <summary>Arkansas</summary>
    public static readonly USState AR = new("AR");

    /// <summary>California</summary>
    public static readonly USState CA = new("CA");

    /// <summary>Colorado</summary>
    public static readonly USState CO = new("CO");

    /// <summary>Connecticut</summary>
    public static readonly USState CT = new("CT");

    /// <summary>Delaware</summary>
    public static readonly USState DE = new("DE");

    /// <summary>Florida</summary>
    public static readonly USState FL = new("FL");

    /// <summary>Georgia</summary>
    public static readonly USState GA = new("GA");

    /// <summary>Hawaii</summary>
    public static readonly USState HI = new("HI");

    /// <summary>Idaho</summary>
    public static readonly USState ID = new("ID");

    /// <summary>Illinois</summary>
    public static readonly USState IL = new("IL");

    /// <summary>Indiana</summary>
    public static readonly USState IN = new("IN");

    /// <summary>Iowa</summary>
    public static readonly USState IA = new("IA");

    /// <summary>Kansas</summary>
    public static readonly USState KS = new("KS");

    /// <summary>Kentucky</summary>
    public static readonly USState KY = new("KY");

    /// <summary>Louisiana</summary>
    public static readonly USState LA = new("LA");

    /// <summary>Maine</summary>
    public static readonly USState ME = new("ME");

    /// <summary>Maryland</summary>
    public static readonly USState MD = new("MD");

    /// <summary>Massachusetts</summary>
    public static readonly USState MA = new("MA");

    /// <summary>Michigan</summary>
    public static readonly USState MI = new("MI");

    /// <summary>Minnesota</summary>
    public static readonly USState MN = new("MN");

    /// <summary>Mississippi</summary>
    public static readonly USState MS = new("MS");

    /// <summary>Missouri</summary>
    public static readonly USState MO = new("MO");

    /// <summary>Montana</summary>
    public static readonly USState MT = new("MT");

    /// <summary>Nebraska</summary>
    public static readonly USState NE = new("NE");

    /// <summary>Nevada</summary>
    public static readonly USState NV = new("NV");

    /// <summary>New Hampshire</summary>
    public static readonly USState NH = new("NH");

    /// <summary>New Jersey</summary>
    public static readonly USState NJ = new("NJ");

    /// <summary>New Mexico</summary>
    public static readonly USState NM = new("NM");

    /// <summary>New York</summary>
    public static readonly USState NY = new("NY");

    /// <summary>North Carolina</summary>
    public static readonly USState NC = new("NC");

    /// <summary>North Dakota</summary>
    public static readonly USState ND = new("ND");

    /// <summary>Ohio</summary>
    public static readonly USState OH = new("OH");

    /// <summary>Oklahoma</summary>
    public static readonly USState OK = new("OK");

    /// <summary>Oregon</summary>
    public static readonly USState OR = new("OR");

    /// <summary>Pennsylvania</summary>
    public static readonly USState PA = new("PA");

    /// <summary>Rhode Island</summary>
    public static readonly USState RI = new("RI");

    /// <summary>South Carolina</summary>
    public static readonly USState SC = new("SC");

    /// <summary>South Dakota</summary>
    public static readonly USState SD = new("SD");

    /// <summary>Tennessee</summary>
    public static readonly USState TN = new("TN");

    /// <summary>Texas</summary>
    public static readonly USState TX = new("TX");

    /// <summary>Utah</summary>
    public static readonly USState UT = new("UT");

    /// <summary>Vermont</summary>
    public static readonly USState VT = new("VT");

    /// <summary>Virginia</summary>
    public static readonly USState VA = new("VA");

    /// <summary>Washington</summary>
    public static readonly USState WA = new("WA");

    /// <summary>West Virginia</summary>
    public static readonly USState WV = new("WV");

    /// <summary>Wisconsin</summary>
    public static readonly USState WI = new("WI");

    /// <summary>Wyoming</summary>
    public static readonly USState WY = new("WY");
}